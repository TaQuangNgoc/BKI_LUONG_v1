﻿function BuildIndexArray(aFiles, aFileTitles, aStopWords)
{
    // filenames & titles
    aFiles["1"] = "Cài .html"
    aFileTitles["1"] = "Cài đặt tham số"
    aFiles["2"] = "Các hình th.html"
    aFileTitles["2"] = "Các hình thức tính lương"
    aFiles["3"] = "Ch.html"
    aFileTitles["3"] = "Chấm công theo thời gian"
    aFiles["4"] = "Danh m.html"
    aFileTitles["4"] = "Danh mục"
    aFiles["5"] = "Lo.html"
    aFileTitles["5"] = "Loại ngày công"
    aFiles["6"] = "Làm thêm gi.html"
    aFileTitles["6"] = "Làm thêm giờ"
    aFiles["7"] = "Ph.html"
    aFileTitles["7"] = "Phụ cấp"
    aFiles["8"] = "B.html"
    aFileTitles["8"] = "Bảo hiểm"
    aFiles["9"] = "Thu.html"
    aFileTitles["9"] = "Thuế"
    aFiles["10"] = "D.html"
    aFileTitles["10"] = "Đoàn phí"
    aFiles["11"] = "S.html"
    aFileTitles["11"] = "Số ngày công tiêu chuẩn"
    aFiles["12"] = "danh mu.html"
    aFileTitles["12"] = "danh mục loại nhân viên"
    aFiles["13"] = "SNewTopic.html"
    aFileTitles["13"] = "Số ngày công tiêu chuẩn"
    aFiles["14"] = "Tham s.html"
    aFileTitles["14"] = "Tham số khác"
    aFiles["15"] = "NewTopic.html"
    aFileTitles["15"] = "Đăng nhập hệ thống"
    aFiles["16"] = "Nh.html"
    aFileTitles["16"] = "Nhập liệu"
    aFiles["17"] = "Thông tin nhân viên.html"
    aFileTitles["17"] = "Thông tin nhân viên"
    aFiles["18"] = "Thêm m.html"
    aFileTitles["18"] = "Thêm mới nhân viên"
    aFiles["19"] = "Thông tin chung.html"
    aFileTitles["19"] = "Thông tin chung"
    aFiles["20"] = "L.html"
    aFileTitles["20"] = "Lương theo thời gian"
    aFiles["21"] = "Các lo.html"
    aFileTitles["21"] = "Các loại lương khác"
    aFiles["22"] = "Su.html"
    aFileTitles["22"] = "Sửa thông tin nhân viên"
    aFiles["23"] = "Châ.html"
    aFileTitles["23"] = "Chấm công từ excel"
    aFiles["24"] = "Theo th.html"
    aFileTitles["24"] = "Theo thời gian"
    aFiles["25"] = "Làm thêm theo th.html"
    aFileTitles["25"] = "Làm thêm theo thời gian"
    aFiles["26"] = "Theo ngày.html"
    aFileTitles["26"] = "Theo ngày"
    aFiles["27"] = "Các loa.html"
    aFileTitles["27"] = "Các loại tiền khác"
    aFiles["28"] = "Báo cáo.html"
    aFileTitles["28"] = "Báo cáo"
    aFiles["29"] = "Ba.html"
    aFileTitles["29"] = "Bảng lương"
    aFiles["30"] = "Xem.html"
    aFileTitles["30"] = "Xem"
    aFiles["31"] = "So.html"
    aFileTitles["31"] = "Soạn thảo"
    aFiles["32"] = "Bâ.html"
    aFileTitles["32"] = "Bât tính năng sửa bảng lương"
    aFiles["33"] = "Chô.html"
    aFileTitles["33"] = "Chốt bảng lương"
    aFiles["34"] = "H.html"
    aFileTitles["34"] = "Hủy chốt bảng lương"
    aFiles["35"] = "Phi.html"
    aFileTitles["35"] = "Phiếu lương"
    aFiles["36"] = "Default.HxC"
    aFileTitles["36"] = "(empty title)"
    aFiles["37"] = "Default.HxF"
    aFileTitles["37"] = "(empty title)"
    aFiles["38"] = "Default.hxk"
    aFileTitles["38"] = "(empty title)"
    aFiles["39"] = "Default_F.hxk"
    aFileTitles["39"] = "(empty title)"
    aFiles["40"] = "Default_N.hxk"
    aFileTitles["40"] = "(empty title)"
    aFiles["41"] = "Default_D.hxk"
    aFileTitles["41"] = "(empty title)"
    aFiles["42"] = "Default_A.hxk"
    aFileTitles["42"] = "(empty title)"
    aFiles["43"] = "Default.hxt"
    aFileTitles["43"] = "(empty title)"
    aFiles["44"] = "COL_Default.HxC"
    aFileTitles["44"] = "(empty title)"
    aFiles["45"] = "COL_Default_K.hxk"
    aFileTitles["45"] = "(empty title)"
    aFiles["46"] = "COL_Default_F.hxk"
    aFileTitles["46"] = "(empty title)"
    aFiles["47"] = "COL_Default_N.hxk"
    aFileTitles["47"] = "(empty title)"
    aFiles["48"] = "COL_Default_D.hxk"
    aFileTitles["48"] = "(empty title)"
    aFiles["49"] = "COL_Default_A.hxk"
    aFileTitles["49"] = "(empty title)"
    aFiles["50"] = "COL_Default.hxt"
    aFileTitles["50"] = "(empty title)"
    aFiles["51"] = "RegisterHelp2.bat"
    aFileTitles["51"] = "(empty title)"
    aFiles["52"] = "UnRegisterHelp2.bat"
    aFileTitles["52"] = "(empty title)"
    aFiles["53"] = "resolveh2link.html"
    aFileTitles["53"] = "(empty title)"
    aFiles["54"] = "webframe.html"
    aFileTitles["54"] = "(empty title)"
    aFiles["55"] = "webframedesktop.html"
    aFileTitles["55"] = "(empty title)"
    aFiles["56"] = "webframemobile.html"
    aFileTitles["56"] = "(empty title)"
    aFiles["57"] = "webframetablet.html"
    aFileTitles["57"] = "(empty title)"
    aFiles["58"] = "webindex.html"
    aFileTitles["58"] = "(empty title)"
    aFiles["59"] = "webnav.html"
    aFileTitles["59"] = "(empty title)"
    aFiles["60"] = "webtoc.html"
    aFileTitles["60"] = "(empty title)"
    aFiles["61"] = "websearch.html"
    aFileTitles["61"] = "(empty title)"

    // stopwords
    aStopWords["_ấn"] = "13,19,20,21"
    aStopWords["_bạn"] = "2,4,5,6,7,8,9,10,11,12,13,14,15,18,19,20,21,22,24,25,26,27,29,30,31,32,33,34,35"
    aStopWords["_bằng"] = "2,4,10,14,20,21"
    aStopWords["_bảng"] = "29,30,31,32,33,34"
    aStopWords["_bao"] = "5,6,7,9,12,15"
    aStopWords["_báo"] = "19,28"
    aStopWords["_bảo"] = "4,7,8,14"
    aStopWords["_bât"] = "32"
    aStopWords["_bất"] = "2,32"
    aStopWords["_bắt"] = "14"
    aStopWords["_bật"] = "29"
    aStopWords["_bên"] = "5,6,7,8,9,12,15,19,20,21"
    aStopWords["_bổ"] = "19"
    aStopWords["_bộ"] = "30"
    aStopWords["_bù"] = "9"
    aStopWords["_bước"] = "22,31"
    aStopWords["_cả"] = "31"
    aStopWords["_các"] = "2,5,6,7,8,9,10,12,14,15,18,19,20,21,22,24,25,26,27,29,30,31"
    aStopWords["_cách"] = "2,4,10,14,20,21"
    aStopWords["_cài"] = "1,11,13"
    aStopWords["_cần"] = "5,6,7,8,9,12,13,15,19,20,21,24,25,26,27,32,35"
    aStopWords["_cẩn"] = "22"
    aStopWords["_cảnh"] = "14"
    aStopWords["_cạnh"] = "19,20,21"
    aStopWords["_cáo"] = "28"
    aStopWords["_cấp"] = "4,7,19"
    aStopWords["_cập"] = "24,25,26,27"
    aStopWords["_cencel"] = "19,20,21"
    aStopWords["_chấm"] = "3,4,23,24,25,26,27"
    aStopWords["_chặn"] = "9"
    aStopWords["_chi"] = "5,6,7,8,9,12"
    aStopWords["_chỉ"] = "29"
    aStopWords["_chỉnh"] = "10,14"
    aStopWords["_cho"] = "13,31"
    aStopWords["_chon"] = "27"
    aStopWords["_chọn"] = "2,4,5,6,7,8,9,12,13,15,19,20,21,22,24,25,26,27,31,32,35"
    aStopWords["_chốt"] = "29,33,34"
    aStopWords["_chưa"] = "29,31"
    aStopWords["_chuẩn"] = "11,13"
    aStopWords["_chung"] = "18,19"
    aStopWords["_có"] = "2,4,5,6,7,8,9,10,11,12,14,15,18,19,20,21,29,30,31"
    aStopWords["_cố"] = "5,8"
    aStopWords["_cơ"] = "2"
    aStopWords["_công"] = "2,3,4,5,6,7,8,9,11,12,13,15,23,24,25,26,27"
    aStopWords["_cụ"] = "11"
    aStopWords["_của"] = "2,5,6,7,8,9,10,11,12,13,15,29,30,32"
    aStopWords["_đã"] = "5,6,7,8,9,12,13,15,24,25,26,27,29,34"
    aStopWords["_đăng"] = "15"
    aStopWords["_danh"] = "4,6,11,12,15,34"
    aStopWords["_đặt"] = "1,11,13"
    aStopWords["_dấu"] = "5,6,7,8,9,12,15"
    aStopWords["_đầu"] = "14"
    aStopWords["_đầy"] = "19"
    aStopWords["_để"] = "27,32,34,35"
    aStopWords["_đi"] = "7"
    aStopWords["_điền"] = "5,6,7,8,9,12,13,14,15,19,20,21,24,25,26,27"
    aStopWords["_điều"] = "10,14,19"
    aStopWords["_định"] = "5,8,14"
    aStopWords["_đó"] = "5,6,7,8,9,12,13,15,19,20,21,22,24,25,26,27"
    aStopWords["_đoàn"] = "4,10"
    aStopWords["_doanh"] = "2"
    aStopWords["_đối"] = "7"
    aStopWords["_đổi"] = "10"
    aStopWords["_dòng"] = "27"
    aStopWords["_đóng"] = "7"
    aStopWords["_dụ"] = "13"
    aStopWords["_dữ"] = "24,25,26,27,31,32"
    aStopWords["_đủ"] = "19"
    aStopWords["_dụng"] = "34"
    aStopWords["_được"] = "7,19,20,21,22,24,25,26,27,31,34"
    aStopWords["_dưới"] = "9"
    aStopWords["_excel"] = "23,24,25,26,27"
    aStopWords["_file"] = "24,25,26,27"
    aStopWords["_form"] = "5,6,7,8,9,12,13,15,19,20,21,22,27,29,32,33"
    aStopWords["_gia"] = "14"
    aStopWords["_giảm"] = "7,14"
    aStopWords["_gian"] = "2,3,4,18,19,20,24,25"
    aStopWords["_giờ"] = "4,6"
    aStopWords["_gồm"] = "5,6,7,8,9,12,15"
    aStopWords["_hai"] = "11"
    aStopWords["_hạng"] = "5,6,7,8,9,12,15,20,21"
    aStopWords["_hay"] = "5,6,7,8,9,12,15"
    aStopWords["_hệ"] = "5,6,7,8,9,12,15"
    aStopWords["_hiểm"] = "4,7,8,14"
    aStopWords["_hiểmhiện"] = "8"
    aStopWords["_hiển"] = "19,20,21,22,24,25,26,27"
    aStopWords["_hiện"] = "5,6,7,8,9,12,13,15,19,20,21,27,29,33"
    aStopWords["_hình"] = "2"
    aStopWords["_hoặc"] = "5,6,7,8,9,12,15"
    aStopWords["_hoàn"] = "13,34"
    aStopWords["_hỏi"] = "5,6,7,8,9,12,15"
    aStopWords["_hội"] = "14"
    aStopWords["_hợp"] = "2,5,6,7,8,9,12,15,29"
    aStopWords["_hưởng"] = "19,20"
    aStopWords["_hủy"] = "29,34"
    aStopWords["_kết"] = "32"
    aStopWords["_khác"] = "14,18,21,27"
    aStopWords["_khai"] = "19"
    aStopWords["_khi"] = "19,34"
    aStopWords["_khoán"] = "2"
    aStopWords["_không"] = "5,6,7,8,9,12,15,31"
    aStopWords["_kì"] = "2,32"
    aStopWords["_là"] = "29"
    aStopWords["_lại"] = "5,6,7,8,9,12,15,19,20,21,27,33"
    aStopWords["_làm"] = "4,6,7,11,25,31"
    aStopWords["_lập"] = "13,35"
    aStopWords["_lcd"] = "5,8"
    aStopWords["_lệ"] = "5,6,7,8,9,12,15"
    aStopWords["_lên"] = "19,20,21,27,29"
    aStopWords["_lí"] = "15"
    aStopWords["_liệu"] = "16,24,25,26,27,31,32"
    aStopWords["_lns"] = "5,6"
    aStopWords["_loại"] = "4,5,6,9,11,12,13,18,19,20,21,25,27"
    aStopWords["_lựa"] = "2"
    aStopWords["_lương"] = "2,5,6,8,14,18,20,21,29,30,31,32,33,34,35"
    aStopWords["_lưu"] = "5,6,7,8,9,11,12,13,15,19,20,21,24,25,26,27,31,32"
    aStopWords["_mà"] = "2"
    aStopWords["_mã"] = "5,6,8,12"
    aStopWords["_mẫu"] = "24,25,26,27"
    aStopWords["_mình"] = "13"
    aStopWords["_mở"] = "24,25,26,27"
    aStopWords["_mỗi"] = "11"
    aStopWords["_mới"] = "5,6,7,8,9,12,15,18,22"
    aStopWords["_mục"] = "4,5,6,7,8,9,10,11,12,14,15,18,19,20,21,22,24,25,26,27,34"
    aStopWords["_muốn"] = "2,4,5,6,7,8,9,12,15,19,20,21,24,25,26,27,33"
    aStopWords["_năm"] = "11,13"
    aStopWords["_năng"] = "5,6,29,32"
    aStopWords["_nào"] = "2,27,32"
    aStopWords["_này"] = "11,34"
    aStopWords["_nếu"] = "19,20,21,24,25,26,27,29"
    aStopWords["_ngày"] = "2,4,5,7,9,11,13,21,26"
    aStopWords["_nghiệp"] = "2"
    aStopWords["_ngphụ"] = "7"
    aStopWords["_ngược"] = "5,6,7,8,9,12,15,19,20,21,27,33"
    aStopWords["_nhân"] = "11,12,13,17,18,19,20,22,31,35"
    aStopWords["_nhấn"] = "5,6,7,8,9,12,15,19,20,21,22,24,25,26,27,31,32,33,34,35"
    aStopWords["_nhận"] = "31"
    aStopWords["_nhập"] = "15,16"
    aStopWords["_nhật"] = "24,25,26,27"
    aStopWords["_nhau"] = "11"
    aStopWords["_như"] = "22,29"
    aStopWords["_no"] = "5,6,7,8,9,12,15,27,33"
    aStopWords["_nơi"] = "24,25,26,27"
    aStopWords["_nút"] = "5,6,7,8,9,12,13,15,19,20,21,22,24,25,26,27,31,32,35"
    aStopWords["_ô"] = "2"
    aStopWords["_ở"] = "10,19,20,21"
    aStopWords["_ok"] = "19,20,21,34"
    aStopWords["_open"] = "24,25,26,27"
    aStopWords["_password"] = "15"
    aStopWords["_phải"] = "7"
    aStopWords["_phẩm"] = "2"
    aStopWords["_phần"] = "8,20"
    aStopWords["_phí"] = "4,10"
    aStopWords["_phiếu"] = "35"
    aStopWords["_phù"] = "2"
    aStopWords["_phụ"] = "4,7,14,19"
    aStopWords["_qua"] = "18"
    aStopWords["_quả"] = "32"
    aStopWords["_quan"] = "2"
    aStopWords["_quản"] = "15"
    aStopWords["_quy"] = "14"
    aStopWords["_ra"] = "5,6,7,8,9,12,13,15,22,24,25,26,27,33"
    aStopWords["_rà"] = "31"
    aStopWords["_rồi"] = "32"
    aStopWords["_sách"] = "15"
    aStopWords["_sản"] = "2"
    aStopWords["_sau"] = "5,6,7,8,9,12,13,15,19,20,21,22,24,25,26,27,29"
    aStopWords["_save"] = "24,25,26,27"
    aStopWords["_sẽ"] = "5,6,7,8,9,12,15,19,20,21"
    aStopWords["_số"] = "1,4,7,10,11,13,14"
    aStopWords["_soạn"] = "31"
    aStopWords["_soát"] = "31"
    aStopWords["_song"] = "11"
    aStopWords["_sử"] = "34"
    aStopWords["_sửa"] = "4,5,6,7,8,9,11,12,15,19,20,21,22,29,32"
    aStopWords["_suất"] = "5,6"
    aStopWords["_sung"] = "19"
    aStopWords["_tác"] = "4,24,25,26,27,29,34"
    aStopWords["_tải"] = "24,25,26,27"
    aStopWords["_tại"] = "22,24,25,26,27"
    aStopWords["_tất"] = "31,34"
    aStopWords["_tên"] = "5,6,7,8,12,22"
    aStopWords["_thái"] = "29"
    aStopWords["_tham"] = "1,4,10,14"
    aStopWords["_tháng"] = "11,13,14,24,25,26,27,29,31,35"
    aStopWords["_thành"] = "5,6,7,8,9,12,13,15"
    aStopWords["_thao"] = "4,24,25,26,27,29"
    aStopWords["_thảo"] = "29,31"
    aStopWords["_thay"] = "10,19,20,21"
    aStopWords["_thế"] = "19,20,21"
    aStopWords["_thể"] = "2,4,5,6,7,8,9,10,11,12,14,15,18,19,20,21,29,30,31"
    aStopWords["_thêm"] = "4,5,6,7,8,9,11,12,15,18,19,20,21,22,25"
    aStopWords["_theo"] = "2,3,4,11,18,20,24,25,26,31,32"
    aStopWords["_thì"] = "29"
    aStopWords["_thị"] = "19,20,21,22,24,25,26,27"
    aStopWords["_thiết"] = "13"
    aStopWords["_thiểu"] = "14"
    aStopWords["_thoát"] = "5,6,7,8,9,12,15,24,25,26,27,31"
    aStopWords["_thời"] = "2,3,4,18,19,20,24,25"
    aStopWords["_thông"] = "5,6,7,8,9,12,14,15,17,18,19,20,21,22,24,25,26,27,30"
    aStopWords["_thống"] = "5,6,7,8,9,12,15"
    aStopWords["_thu"] = "2"
    aStopWords["_thức"] = "2"
    aStopWords["_thực"] = "29"
    aStopWords["_thuế"] = "7,9"
    aStopWords["_thuộc"] = "7,14"
    aStopWords["_tỉ"] = "5,6,7,9"
    aStopWords["_tích"] = "2,21"
    aStopWords["_tiền"] = "7,27"
    aStopWords["_tiếp"] = "10,13,14,22"
    aStopWords["_tiết"] = "5,6,7,8,9,12"
    aStopWords["_tiêu"] = "11,13"
    aStopWords["_tin"] = "5,6,7,8,9,12,15,17,18,19,20,21,22,24,25,26,27,30"
    aStopWords["_tính"] = "2,29,31,32"
    aStopWords["_toàn"] = "30"
    aStopWords["_tối"] = "14"
    aStopWords["_tổng"] = "29"
    aStopWords["_trăm"] = "8,20"
    aStopWords["_trạng"] = "29"
    aStopWords["_trên"] = "4,5,6,7,8,9,12,15,19,20,21,27,32"
    aStopWords["_trong"] = "31"
    aStopWords["_trống"] = "2"
    aStopWords["_trừ"] = "7,9,14"
    aStopWords["_trực"] = "10,14"
    aStopWords["_từ"] = "23"
    aStopWords["_tục"] = "13,22"
    aStopWords["_từng"] = "4,11,13"
    aStopWords["_tương"] = "5,6,7,8,9,12,15,19,20,21,24,25,26,27"
    aStopWords["_tượng"] = "7"
    aStopWords["_ty"] = "2"
    aStopWords["_ứng"] = "5,6,7,8,9,11,12,15,19,20,21,24,25,26,27"
    aStopWords["_upload"] = "24,25,26,27"
    aStopWords["_user"] = "15"
    aStopWords["_username"] = "15"
    aStopWords["_và"] = "20,21,24,25,26,27"
    aStopWords["_vào"] = "2,5,6,7,8,9,12,14,15,19,20,21,24,25,26,27"
    aStopWords["_về"] = "20"
    aStopWords["_ví"] = "13"
    aStopWords["_việc"] = "13"
    aStopWords["_viên"] = "11,12,13,17,18,19,20,22,31,35"
    aStopWords["_viết"] = "5,6,7,8,9,12,15"
    aStopWords["_với"] = "2,5,6,7,8,9,11,12,15"
    aStopWords["_vụ"] = "34"
    aStopWords["_vừa"] = "19"
    aStopWords["_x"] = "5,6,7,8,9,12,15"
    aStopWords["_xã"] = "14"
    aStopWords["_xác"] = "31"
    aStopWords["_xem"] = "4,5,6,7,8,9,12,15,24,25,26,27,29,30,35"
    aStopWords["_xóa"] = "4,5,6,7,8,9,11,12,15,19,20,21,27"
    aStopWords["_xoạn"] = "29"
    aStopWords["_ý"] = "11,32"
    aStopWords["_yes"] = "5,6,7,8,9,12,15,27,33"
}
