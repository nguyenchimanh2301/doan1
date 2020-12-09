using System;
using System.Collections.Generic;
using System.Text;
using QL_KTX.Businisse.IBLL;
using QL_KTX.Entities;
using QL_KTX.Businisse;
using QL_KTX.DataAcessLayer;

namespace QL_KTX.Presentation
{
    class FormPhong
    {
        private BLLphong pbll = new BLLphong();
        GD gd = new GD(100, 50);
        public void menuphong()
        {
            FormMENU menu = new FormMENU();
            for (int i = 8; i < 28; ++i)
            {

                gd.pain("║", 7, i);
                gd.pain("║", 92, i);
            }

            gd.pain("╔════════════════════════════════════════════════════════════════════════════════════╗", 7, 7);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 13);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 19);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 22);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 25);

            for (int i = 11; i < 28; ++i)
            {

                gd.pain("║", 39, i);
            }
            gd.pain("╚═══════════════════════════════╩════════════════════════════════════════════════════╝", 7, 28);
            gd.pain("CÁC THAO TÁC QUẢN LÍ PHÒNG KÍ TÚC", 30, 9);
            gd.pain("F1", 9, 12); gd.pain("THÊM PHÒNG KÍ TÚC", 60, 12);
            gd.pain("F2", 9, 15); gd.pain("HIỆN THÔNG TIN", 60, 15);
            gd.pain("F3", 9, 18); gd.pain("SỬA PHÒNG KÍ TÚC", 60, 18);
            gd.pain("F4", 9, 21); gd.pain("XÓA PHÒNG KÍ TÚC", 60, 21);
            gd.pain("F5", 9, 24); gd.pain("TÌM PHÒNG KÍ TÚC", 60, 24);
            gd.pain("ESC", 9, 27); gd.pain("TRỞ LẠI", 60, 27);
            Console.SetCursorPosition(40, 30);
        Phong: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1: Console.Clear(); themt(); break;
                case ConsoleKey.F2: Console.Clear(); hien(); break;
                case ConsoleKey.F3: Console.Clear(); suaphong(); break;
                case ConsoleKey.F4: Console.Clear(); xoaphong(); break;
                case ConsoleKey.F5: Console.Clear(); timphong(); break;
                case ConsoleKey.Escape: Console.Clear(); menu.menu(); break;
                default:
                    gd.pain("sai thao tác!! mòi nhập lại", 30, 30); Console.SetCursorPosition(40, 30);
                    goto Phong;
            }
        }
        public void themt()
        {
            Phongkt ph = new Phongkt();
            for (int i = 11; i < 25; ++i)
            {
                gd.pain("║", 7, i);
                gd.pain("║", 92, i);
            }
            gd.pain("╔════════════════════════════════════════════════════════════════════════════════════╗", 7, 10);
            gd.pain("╠═══════════════════════════════╬════════════════════════════════════════════════════╣", 7, 13);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 19);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 22);
            for (int i = 11; i < 25; ++i)
            {

                gd.pain("║", 39, i);
            }
            gd.pain("╚═══════════════════════════════╩════════════════════════════════════════════════════╝", 7, 25);
            do
            {
                gd.ve(9, 12); Console.WriteLine("Nhập mã phòng");
                gd.ve(50, 12); ph.Maph = Console.ReadLine();
            } while (string.IsNullOrEmpty(ph.Maph));
            do
            {
                gd.ve(9, 15); Console.WriteLine("Nhập tên dãy");
                gd.ve(50, 15); ph.Tenday = Console.ReadLine();
            } while (string.IsNullOrEmpty(ph.Tenday));
        slmax: gd.pain("", 50, 18);
            try
            {
                gd.ve(9, 18); Console.WriteLine("Nhập sl hoc sinh max");
                gd.ve(50, 18); ph.Soluongmax = int.Parse(Console.ReadLine());
            }
            catch
            {
                gd.ve(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu là chữ,mời nhập lại");
                goto slmax;
            }
        dango: gd.pain("", 50, 21);
            try
            {
                gd.ve(9, 21); Console.WriteLine("Nhập sl hoc sinh đang ở");
                gd.ve(50, 21); ph.Dango = int.Parse(Console.ReadLine());
            }
            catch
            {
                gd.ve(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu là chữ,mời nhập lại");
                goto dango;
            }
            do
            {
                gd.ve(9, 24); Console.WriteLine("Cho biết tình trạng phòng");
                gd.ve(50, 24); ph.Tinhtrang = Console.ReadLine();
            } while (string.IsNullOrEmpty(ph.Tinhtrang));

            pbll.themphong(ph);
            Console.SetCursorPosition(40, 30);
            gd.pain("F1", 20, 27); gd.pain("THÊM VÀ NHẬP TIẾP", 30, 27);
            gd.pain("F2", 20, 28); gd.pain("HIỆN THÔNG TIN", 30, 28);
            gd.pain("F3", 20, 29); gd.pain("TRỞ LẠI", 30, 29);
            Console.SetCursorPosition(40, 30);
            ConsoleKeyInfo kt = Console.ReadKey();
        n:
            switch (kt.Key)
            {
                case ConsoleKey.F1: Console.Clear(); themt(); Console.Clear(); break;
                case ConsoleKey.F2: Console.Clear(); hien(); break;
                case ConsoleKey.F3: Console.Clear(); menuphong(); break;
                default:
                    Console.WriteLine("sai thao tác!!! mời nhập lại"); Console.SetCursorPosition(40, 30);
                    goto n;
            }
        }
        public void hien()
        {
            List<Phongkt> list = pbll.LPhong();
            Console.WriteLine("\n\n\n\n\n\n\n");
            int j = 6;
            foreach (var p in list)
            {

                gd.pain(Convert.ToString(p.Maph), 12, j);
                gd.pain(Convert.ToString(p.Tenday), 24, j);
                gd.pain(Convert.ToString(p.Soluongmax), 40, j);
                gd.pain(Convert.ToString(p.Dango), 61, j);
                gd.pain(Convert.ToString(p.Tinhtrang), 78, j);

                j++;
            }
            for (int i = 4; i < 45; ++i)
            {
                gd.pain("║", 7, i);
                gd.pain("║", 91, i);
            }
            gd.pain("KÍ TÚC XÁ TRƯỜNG ĐẠI HỌC SƯ PHẠM KĨ THUẬT HƯNG YÊN(PHÒNG KÍ TÚC)", 20, 2);
            gd.pain("MÃ PHÒNG", 10, 4); gd.pain("TÊN DÃY", 25, 4); gd.pain("SỐ LƯỢNG TỐI ĐA", 38, 4); gd.pain("ĐANG Ở HIỆN TẠI", 56, 4); gd.pain("TÌNH TRẠNG", 75, 4);

            gd.pain("╔══════════════╦════════════╦══════════════════╦═══════════════════╦════════════════╗", 7, 3);

            for (int i = 4; i < 45; ++i)
            {
                gd.pain("║", 22, i);
                gd.pain("║", 35, i);
                gd.pain("║", 54, i);
                gd.pain("║", 74, i);
            }
            gd.pain("╚══════════════╩════════════╩══════════════════╩═══════════════════╩════════════════╝", 7, 45);
            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU PHÒNG", 20, 47);
        ne:
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.Tab: Console.Clear(); menuphong(); break;
                default:
                    Console.WriteLine("sai thao tác!!! mời nhập lại"); Console.SetCursorPosition(40, 47);
                    goto ne;
            }

        }
        public void suaphong()
        {
            Console.Clear();
            Console.WriteLine("SỬA THÔNG TIN PHÒNG");
            List<Phongkt> list = pbll.LPhong();
            string map;
            Console.Write("Nhập mã phòng cần sửa:");
            map = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Maph == map) break;

            if (i < list.Count)
            {
                Phongkt p = new Phongkt(list[i]);
                Console.Write("Nhậpp tên dãy:");
                string day = Console.ReadLine();
                if (!string.IsNullOrEmpty(day)) p.Tenday = day;
                Console.Write("Nhap so luong nguoi o moi");
                int sno = int.Parse(Console.ReadLine());
                if (sno > 0) p.Dango = sno;
                Console.WriteLine("Tinh trang phong");
                string ttp = Console.ReadLine();
                if (!string.IsNullOrEmpty(ttp)) p.Tinhtrang = ttp;
                pbll.suaphong(p);
            }
            else
            {
                Console.WriteLine("Không tồn tại mã phòng này");
            }
        suaphong:
            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU PHÒNG", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F2: Console.Clear(); suaphong(); break;
                case ConsoleKey.Tab: Console.Clear(); menuphong(); break;
                default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto suaphong;
            }

        }
        public void xoaphong()
        {

            Console.WriteLine("XÓA THÔNG TIN PHÒNG");
            List<Phongkt> list = pbll.LPhong();
            string map;
            Console.Write("nhập mã phòng muốn xóa");
            map = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Maph == map) break;

            if (i < list.Count)
            {
                Phongkt p = new Phongkt(list[i]);
                pbll.xoaphong(map);
            }
            else
            {
                Console.WriteLine("Không tồn tại mã phòng này");
            }
        xoaphong:
            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU PHÒNG", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.Tab: Console.Clear(); menuphong(); break;
                default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto xoaphong;
            }

        }
        public void timphong()
        {
            Console.WriteLine();
            List<Phongkt> list = pbll.LPhong();
            gd.pain("TÌM KIẾM THÔNG TIN PHÒNG", 35, 3);
            string maph; gd.pain("Nhập mã phòng cần tìm :",20, 5);
            do
            {
                gd.ve(49, 5); maph = Console.ReadLine();
            } while (string.IsNullOrEmpty(maph));
            int i;
            for (i = 0; i < list.Count; i++)
                if (list[i].Maph == maph) break;
            if (i < list.Count)
            {
                Phongkt ph = new Phongkt(list[i]);
                Console.WriteLine("\n\n");
                Console.WriteLine("THÔNG TIN PHÒNG  MUỐN TÌM");
                gd.pain("MÃ PHÒNG :", 14, 13); gd.ve(34, 13); Console.WriteLine(list[i].Maph);
                gd.pain("TÊN DÃY  :", 14, 15); ; gd.ve(34, 15); Console.WriteLine(list[i].Tenday);
                gd.pain("SỐ LƯỢNG TỐI ĐA:", 14, 17); ; gd.ve(34,17); Console.WriteLine(list[i].Soluongmax);
                gd.pain("ĐANG Ở HIỆN TẠI:", 14, 19); gd.ve(34, 19); Console.WriteLine(list[i].Dango);
                gd.pain("TÌNH TRẠNG:", 14, 21); gd.ve(34, 21); Console.WriteLine(list[i].Tinhtrang);
            }
            else
                Console.WriteLine("không tồn tại mã phòng này");
            timhd:
            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU PHÒNG ", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.Tab: Console.Clear(); menuphong(); break;
                default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto timhd;
            }
        }
    
    }

}




























































































































































































































