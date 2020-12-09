using QL_KTX.Businisse;
using QL_KTX.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KTX.Presentation
{
    class FormSV
    {
        private BLLSV svbll = new BLLSV();
        GD gd = new GD(100, 50);

        public void menusv()
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
            gd.pain("CÁC THAO TÁC QUẢN LÍ SINH VIÊN", 30, 9);
            gd.pain("F1", 9, 12); gd.pain("THÊM SINH VIÊN", 60, 12);
            gd.pain("F2", 9, 15); gd.pain("HIỆN THÔNG TIN", 60, 15);
            gd.pain("F3", 9, 18); gd.pain("SỬA THÔNG TIN SINH VIÊN", 60, 18);
            gd.pain("F4", 9, 21); gd.pain("XÓA SINH VIÊN", 60, 21);
            gd.pain("F5", 9, 24); gd.pain("TÌM SINH VIÊN", 60, 24);
            gd.pain("ESC", 9, 27); gd.pain("TRỞ LẠI", 60, 27);
        sv: ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1: Console.Clear(); them(); break;
                case ConsoleKey.F2: Console.Clear(); hien(); break;
                case ConsoleKey.F3: Console.Clear(); suasv(); break;
                case ConsoleKey.F4: Console.Clear(); xoasv(); break;
                case ConsoleKey.F5: Console.Clear(); timsv(); break;
                case ConsoleKey.Escape: Console.Clear(); menu.menu(); break;
                default:
                    goto sv;
            }
        }
        public void them()
        {
            Console.InputEncoding = Encoding.UTF8;
            SV sv = new SV();
            gd.pain("THÊM SINH VIÊN", 40, 9);
            for (int i = 8; i < 31; ++i)
            {
                gd.pain("║", 7, i);
                gd.pain("║", 92, i);

            }
            gd.pain("╔════════════════════════════════════════════════════════════════════════════════════╗", 7, 7);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
            gd.pain("╠═══════════════════════════════╬════════════════════════════════════════════════════╣", 7, 13);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 19);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 22);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 25);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 28);

            for (int i = 11; i < 31; ++i)
            {

                gd.pain("║", 39, i);
            }
            gd.pain("╚═══════════════════════════════╩════════════════════════════════════════════════════╝", 7, 31);
           
            do
            {
                gd.ve(9, 12); Console.WriteLine("Nhập mã phòng"); gd.ve(50, 12); sv.Maph = Console.ReadLine();
            } while (string.IsNullOrEmpty(sv.Maph));

            do
            {
                gd.ve(9, 15); Console.WriteLine("Nhập mã sinh viên"); gd.ve(50, 15); sv.Masv = Console.ReadLine();
            } while (string.IsNullOrEmpty(sv.Masv));
            do
            {
                gd.ve(9, 18); Console.WriteLine("Nhập tên sinh viên"); gd.ve(50, 18); sv.Tensv = Console.ReadLine();
            } while (string.IsNullOrEmpty(sv.Tensv));
            do
            {
                gd.ve(9, 21); Console.WriteLine(" giới tính sinh viên là "); gd.ve(50, 21); sv.Gioitinh = Console.ReadLine();
            } while (string.IsNullOrEmpty(sv.Gioitinh));
            do
            {
                gd.ve(9, 24); Console.WriteLine("Nhập địa chỉ"); gd.ve(50, 27); sv.Diachi = Console.ReadLine();
            } while (string.IsNullOrEmpty(sv.Diachi));
            do
            {
                gd.ve(9, 27); Console.WriteLine("Nhập tên lớp"); gd.ve(50, 27); sv.Tenlop = Console.ReadLine();
            } while (string.IsNullOrEmpty(sv.Tenlop));
        sdt: gd.pain("", 50, 30);
            try
            {
                Console.SetCursorPosition(9, 30); Console.WriteLine("nhập số điện thoại");
                Console.SetCursorPosition(50, 30); sv.Sdt1 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu ,mời nhập lại");
                goto sdt;
            }
            svbll.themsv(sv);
        svs:
            gd.pain("F1", 20, 33); gd.pain("THÊM VÀ NHẬP TIẾP", 30, 33);
            gd.pain("F2", 20, 34); gd.pain("HIỆN THÔNG TIN", 30, 34);
            gd.pain("F3", 20, 35); gd.pain("TRỞ LẠI", 30, 35);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1:; Console.Clear(); them(); Console.Clear(); break;
                case ConsoleKey.F2: Console.Clear(); hien(); break;
                case ConsoleKey.F3: Console.Clear(); menusv(); break;
                default:
                    Console.WriteLine("sai thao tác!! mời nhập lại");
                    goto svs;
            }
        }
        public void hien()
        {
            List<SV> list = svbll.LSV();
            int j = 5;

            foreach (var p in list)
            {
                gd.pain(Convert.ToString(p.Maph), 5, j);
                gd.pain(Convert.ToString(p.Masv), 12, j);
                gd.pain(Convert.ToString(p.Tensv), 24, j);
                gd.pain(Convert.ToString(p.Gioitinh), 44, j);
                gd.pain(Convert.ToString(p.Diachi), 54, j);
                gd.pain(Convert.ToString(p.Tenlop), 66, j);
                gd.pain(Convert.ToString(p.Sdt1), 82, j);
                j++;
            }
            for (int i = 3; i < 45; ++i)
            {
                gd.pain("║", 2, i);
                gd.pain("║", 96, i);
            }
            gd.pain("MÃ PHÒNG", 3, 3); gd.pain(" MÃ SV", 14, 3); gd.pain("HỌ TÊN", 30, 3); gd.pain("GIỚI TÍNH", 44, 3); gd.pain("ĐỊA CHỈ", 56, 3); gd.pain("TÊN LỚP", 69, 3); gd.pain("SỐ ĐT", 85, 3);
            gd.pain("╔════════╦═══════════╦═══════════════════╦═════════╦═══════════╦════════════╦═════════════════╗", 2, 2);
            gd.pain("╚════════╩═══════════╩═══════════════════╩═════════╩═══════════╩════════════╩═════════════════╝", 2, 45);
            for (int i = 3; i < 45; ++i)
            {
                gd.pain("║", 11, i);
                gd.pain("║", 23, i);
                gd.pain("║", 43, i);
                gd.pain("║", 53, i);
                gd.pain("║", 65, i);
                gd.pain("║", 78, i);
            }   
            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU SINH VIÊN", 20, 47);
        menuss:
            ConsoleKeyInfo kt = Console.ReadKey();  
            switch (kt.Key)
            {
                case ConsoleKey.Tab: Console.Clear(); menusv(); break;
                default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto menuss;
            }
        }
        public void suasv()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("SỬA THÔNG TIN SINH VIÊN");
            List<SV> list = svbll.LSV();
            string masv;
            Console.Write("Nhập mã sinh viên cần sửa:");
            masv = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Maph == masv) break;

            if (i < list.Count)
            {
                SV s = new SV(list[i]);
                Console.Write("Nhập mã phòng mới:");
                string mpm = Console.ReadLine();
                if (!string.IsNullOrEmpty(mpm)) s.Maph = mpm;
                Console.Write("Nhập tên sv mới");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten)) s.Tensv = ten;
                Console.WriteLine("giới tính mới");
                string gtm = Console.ReadLine();
                if (!string.IsNullOrEmpty(gtm)) s.Gioitinh = gtm;
                Console.WriteLine("địa chỉ mới");
                string dcm = Console.ReadLine();
                if (!string.IsNullOrEmpty(dcm)) s.Diachi = dcm;
                Console.WriteLine("tên lớp mới");
                string tlm = Console.ReadLine();
                if (!string.IsNullOrEmpty(tlm)) s.Tenlop = tlm;
                Console.WriteLine("số điện thoại mới");
                int sdtm = int.Parse(Console.ReadLine());
                if (sdtm > 0) s.Sdt1 = sdtm;
                svbll.suattsv(s);
            }
            else
            {
                Console.WriteLine("không tồn tại mã sinh viên");
            }

            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU SINH VIÊN", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
        suasv:
            switch (kt.Key)
            {
                case ConsoleKey.Tab: Console.Clear(); menusv(); break;
                default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto suasv;
            }

        }
        public void xoasv()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("XOÁ THÔNG TIN SINH VIÊN");
            List<SV> list = svbll.LSV();
            string masv;
            Console.Write("nhập mã sinh viên muốn xóa");
            masv = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Masv == masv) break;
            if (i < list.Count)
            {
                SV sv = new SV(list[i]);
                svbll.xoasv(masv);
            }
            else
            {
                Console.WriteLine("không tồn tại mã sv");
            }
        xoasv:
            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU SINH VIÊN", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {

                case ConsoleKey.Tab: Console.Clear(); menusv(); break;
                default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto xoasv;
            }
        }
        public void timsv()
        {
            gd.pain("TÌM THÔNG TIN SINH VIÊN", 30, 5);
            List<SV> list = svbll.LSV();
            Console.Write("nhập mã sinh viên muốn tìm "); string masv;
            masv = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Masv == masv) break;

            if (i < list.Count)
            {
                SV sv = new SV(list[i]);
                Console.WriteLine("\n\n");
                Console.WriteLine("THÔNG TIN SINH VIÊN  MUỐN TÌM");
                gd.pain("MÃ PHÒNG", 14, 13);gd.ve(28, 13); Console.WriteLine(list[i].Maph);
                gd.pain(" MÃ SV", 14, 15); ; gd.ve(28, 15); Console.WriteLine(list[i].Masv);
                gd.pain("HỌ TÊN", 14, 17); ; gd.ve(28, 17); Console.WriteLine(list[i].Tensv);
                gd.pain("GIỚI TÍNH", 14, 19); gd.ve(28, 19); Console.WriteLine(list[i].Gioitinh);
                gd.pain("ĐỊA CHỈ", 14, 21); gd.ve(28, 21); Console.WriteLine(list[i].Diachi);
                gd.pain("TÊN LỚP", 14, 23); gd.ve(28, 23); Console.WriteLine(list[i].Tenlop);
                gd.pain("SỐ ĐT", 14, 25); gd.ve(28, 25); Console.WriteLine(list[i].Sdt1);
            }
            else
            {
                Console.WriteLine("không tồn tại mã sinh viên");
            }
        timhd:
            gd.pain("ẤN TAB ĐỂ QUAY LẠI MENU SINH VIÊN", 20, 47);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.Tab: Console.Clear(); menusv(); break;
                default:
                    Console.WriteLine("sai thao tác! mời nhập lại");
                    goto timhd;
            }
        }
    }
}




