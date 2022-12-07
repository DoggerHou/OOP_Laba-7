using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace OOP_Laba_7
{
    public class Group : Model
    {
        private List<Model> group;
        private List<Model> groupObjects;//Список из всех объектов в группе(кроме самих групп)

        int left_Board;  //Границы рамки группы
        int right_Board;
        int up_Board;
        int down_Board;


        public Group()
        {
            group = new List<Model>();
            groupObjects = new List<Model>();
            detail = true;
        }



        //"Распаковка" нашей группы(получаем еще один List<Model>, только из отрисовываемых объектов
        private void unpack_Group()
        {
            for (int i = groupObjects.Count - 1; i >= 0; i--)
            {
                if (groupObjects[i] is Group)
                {
                    groupObjects.AddRange(((Group)groupObjects[i]).groupObjects);
                    groupObjects.Remove(groupObjects[i]);
                    unpack_Group();
                }
            }
        }


        //Возвращаем группу 
        public List<Model> getGroup()
        {
            return group;
        }


        public void add_in_Group(Model temp_object)
        {
            group.Add(temp_object);
            groupObjects.Add(temp_object);
            unpack_Group();
        }


        //получить информацию, выделена ли наша группа
        public override bool isDetailed()
        {
            return detail;
        }


        //Установить цвет у всей группы
        public override void setColor(Color color)
        {
            foreach (var obj in groupObjects)
                obj.setColor(color);
        }


        //Отрисовка объектов группы и рамки
        public override void OnPaint(PaintEventArgs e)
        {
            left_Board = int.MaxValue;
            right_Board = int.MinValue;
            up_Board = int.MaxValue;
            down_Board = int.MinValue;

            //Отрисывывает все элементы
            foreach (var obj in groupObjects)
            {
                obj.OnPaint(e);
            }

            //Высчитывает координаты рамки
            foreach (var obj in groupObjects)
            {
                var tuple = obj.getGroupBoards();

                left_Board = Math.Min(left_Board, tuple.Item1);
                right_Board = Math.Max(right_Board, tuple.Item2);
                up_Board = Math.Min(up_Board, tuple.Item3);
                down_Board = Math.Max(down_Board, tuple.Item4);
            }

            //Рисует рамку
            Pen pen = new Pen(Color.Red);
            if (detail)
                pen.Width = 3;
            else
                pen.Width = 1;
            e.Graphics.DrawRectangle(pen, left_Board - 8, up_Board - 8, right_Board - left_Board + 16, down_Board - up_Board + 16);
        }


        //Попали ли мы в область рамки группы
        public override bool isPicked(MouseEventArgs e, bool controlUp)
        {
            if ((e.X >= left_Board - 8) & (e.X <= right_Board + 16) &
                (e.Y >= up_Board - 8) & (e.Y <= down_Board + 16) & controlUp)
            {
                detail = !detail; //Инвертируем выделенность
                return true;
            }
            return false;//не попал в рамку - ниче не делает
        }


        //Можем ли сдвинуть ВСЕ объекты группы
        public override bool isMovable(int point_X, int point_Y)
        {
            foreach (var obj in groupObjects)
                if (obj.isMovable(point_X, point_Y) == false)
                    return false;
            return true;
        }


        //Можем ли увеличить ВСЕ объекты группы
        public override bool isIncreasable(int _radix)
        {
            foreach (var obj in groupObjects)
                if (obj.isIncreasable(_radix) == false)
                    return false;
            return true;
        }


        //Двигает ВСЕ объекты группы
        public override void MoveObject(int _X, int _Y)
        {
            if (isMovable(_X, _Y))
                foreach (var obj in groupObjects)
                    obj.MoveObject(_X, _Y);
        }


        //Увеличить размер ВСЕХ объектов группы
        public override void IncreaseObjectSize(int _radix)
        {
            if (isIncreasable(_radix))
                foreach (var obj in groupObjects)
                    obj.IncreaseObjectSize(_radix);
        }


        //Уменьшить размер ВСЕХ объектов группы
        public override void DecreaseObjectSize(int _radix)
        {
            foreach (var obj in groupObjects)
                obj.DecreaseObjectSize(_radix);
        }


        public override void SaveObject(StreamWriter save)
        {
            save.WriteLine("Group");
            save.WriteLine(group.Count.ToString());
            foreach (var obj in group)
                obj.SaveObject(save);
        }


        public override void LoadObject(StreamReader load, ModelFactory factory)
        {
            int count = int.Parse(load.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Model temp;
                temp = factory.CreateObject(load.ReadLine());
                temp.LoadObject(load, factory);
                group.Add(temp);
            }
            groupObjects.AddRange(group);
            unpack_Group();
        }
    }
}
