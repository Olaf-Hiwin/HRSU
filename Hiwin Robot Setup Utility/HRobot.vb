Imports System.Text
Imports System.Runtime.InteropServices

Module HRobot
    Public Delegate Sub CallBackFun(command As UInt16, rlt As UInt16, ByRef msg As UInt16, len As Integer)
    <DllImport("HRSDK.dll")> Public Sub HRSDKDebug(robot As Integer, id As Integer)
    End Sub
    <DllImport("HRSDK.dll")> Public Function open_connection(ByVal ip As String, mode As Integer, func As CallBackFun) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Sub disconnect(robot As Integer)
    End Sub
    <DllImport("HRSDK.dll")> Public Function get_hrsdk_version(version As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_connection_level(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_connection_level(robot As Integer, level As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_timer(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_timer(robot As Integer, index As Integer, value As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_timer_start(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_timer_stop(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_timer_name(robot As Integer, index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_timer_name(robot As Integer, index As Integer, comment() As UShort, array_size As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_timer_status(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_counter(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_counter(robot As Integer, index As Integer, value As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_counter_name(robot As Integer, index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_counter_name(robot As Integer, index As Integer, comment() As UShort, array_size As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_pr_type(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_pr_type(robot As Integer, index As Integer, value As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_pr_coordinate(robot As Integer, index As Integer, ByVal value() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_pr_coordinate(robot As Integer, index As Integer, ByVal value() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_pr_comment(robot As Integer, index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_pr_comment(robot As Integer, index As Integer, comment() As UShort, array_size As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_pr_tool_base(robot As Integer, index As Integer, ByVal value() As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_pr_tool_base(robot As Integer, index As Integer, tool As Integer, base As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_pr(robot As Integer, pr_num As Integer, pr_type As Integer, coor() As Double, ext_pos() As Double, tool As Integer, base As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_pr(robot As Integer, pr_num As Integer, ByRef pr_type As Integer, ByVal coor() As Double, ByVal ext_pos() As Double, ByRef tool As Integer, ByRef base As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function remove_pr(robot As Integer, pr_num As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_acc_dec_ratio(robot As Integer, v As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_acc_time(robot As Integer, v As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_acc_dec_ratio(robot As Integer) As Double
    End Function
    <DllImport("HRSDK.dll")> Public Function get_acc_time(robot As Integer) As Double
    End Function
    <DllImport("HRSDK.dll")> Public Function set_ptp_speed(robot As Integer, v As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_ptp_speed(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_lin_speed(robot As Integer, v As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_lin_speed(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_override_ratio(robot As Integer, v As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_override_ratio(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_robot_id(robot As Integer, id As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_robot_id(robot As Integer, ByRef id As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_smooth_length(robot As Integer, radius As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_alarm_code(robot As Integer, ByRef count As Integer, ByVal alarm_code() As UInt64) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_digital_input(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_digital_output(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_digital_output(robot As Integer, index As Integer, On_Off As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_function_input(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_function_output(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_robot_input(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_robot_output(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_robot_output(robot As Integer, index As Integer, On_Off As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_valve_output(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_valve_output(robot As Integer, index As Integer, On_Off As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_DI_simulation_Enable(robot As Integer, index As Integer, On_Off As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_DI_simulation(robot As Integer, index As Integer, On_Off As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_DI_simulation_Enable(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_base_number(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_base_number(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_base_data(robot As Integer, index As Integer, ByVal data() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function define_base(robot As Integer, index As Integer, data() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_tool_number(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_tool_number(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_tool_data(robot As Integer, index As Integer, ByVal data() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function define_tool(robot As Integer, index As Integer, data() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_home_point(robot As Integer, data() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_home_point(robot As Integer, data() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_previous_pos(robot As Integer, data() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ext_task_start(robot As Integer, mode As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function task_start(robot As Integer, name As String) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function task_hold(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function task_abort(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function task_continue(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_rsr(robot As Integer, file_name As String, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function remove_rsr(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_rsr_prog_name(robot As Integer, index As Integer, file_name As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_execute_file_name(robot As Integer, file_name As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function remove_command(robot As Integer, num As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function remove_command_tail(robot As Integer, num As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function send_file(robot As Integer, from_file_path As String, to_file_path As String) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function download_file(robot As Integer, from_file_path As String, to_file_path As String) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_hrss_mode(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_motor_state(robot As Integer, onOff As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_motor_state(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_operation_mode(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_operation_mode(robot As Integer, mode As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function clear_alarm(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function update_hrss(robot As Integer, path As String) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_module_input_config(robot As Integer, index As Integer, ByRef sim As Boolean, ByRef value As Boolean, ByRef type As Integer, ByRef start As Integer, ByRef _end As Integer, comment() As UShort, array_size As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_module_output_config(robot As Integer, index As Integer, ByRef value As Boolean, ByRef type As Integer, ByRef start As Integer, ByRef _end As Integer, comment() As UShort, array_size As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_input_simulation(robot As Integer, index As Integer, enable As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_input_value(robot As Integer, index As Integer, enable As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_input_start(robot As Integer, index As Integer, start_number As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_input_end(robot As Integer, index As Integer, end_number As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_input_comment(robot As Integer, index As Integer, commentcomment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_output_value(robot As Integer, index As Integer, enable As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_output_start(robot As Integer, index As Integer, start_number As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_output_end(robot As Integer, index As Integer, end_number As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_output_comment(robot As Integer, index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_SI_range(robot As Integer, start_number As Integer, end_number As Integer, value() As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_SO_range(robot As Integer, start_number As Integer, end_number As Integer, value() As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_fieldbus_rs_srw_range(robot As Integer, start_number As Integer, end_number As Integer, value() As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_fieldbus_rs_srr_range(robot As Integer, start_number As Integer, end_number As Integer, value() As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_SO_array(robot As Integer, index() As Integer, value() As Integer, array_size As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_fieldbus_srw_array(robot As Integer, index() As Integer, value() As Integer, array_size As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function jog(robot As Integer, type As Integer, index As Integer, dir As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function jog_stop(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function jog_home(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ptp_axis(robot As Integer, mode As Integer, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ptp_pos(robot As Integer, mode As Integer, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ptp_rel_pos(robot As Integer, mode As Integer, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ptp_rel_axis(robot As Integer, mode As Integer, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ptp_pr(robot As Integer, mode As Integer, point As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function lin_axis(robot As Integer, mode As Integer, smooth_value As Double, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function lin_pos(robot As Integer, mode As Integer, smooth_value As Double, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function lin_rel_pos(robot As Integer, mode As Integer, smooth_value As Double, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function lin_rel_axis(robot As Integer, mode As Integer, smooth_value As Double, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function lin_pr(robot As Integer, mode As Integer, smooth_value As Double, point As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function circ_pos(robot As Integer, mode As Integer, point_aux() As Double, point_end() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function circ_axis(robot As Integer, mode As Integer, point_aux() As Double, point_end() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function circ_pr(robot As Integer, mode As Integer, point_aux As Integer, point_end As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_motion_state(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function motion_hold(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function motion_continue(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function motion_abort(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function motion_delay(robot As Integer, delay As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_command_id(robot As Integer, num As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_command_id(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_command_count(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_encoder_count(robot As Integer, value() As Int32) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_current_joint(robot As Integer, value() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_current_position(robot As Integer, value() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_current_rpm(robot As Integer, value() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_device_born_date(robot As Integer, _date() As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_operation_time(robot As Integer, value() As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_mileage(robot As Integer, value() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_total_mileage(robot As Integer, value() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_utilization(robot As Integer, value() As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_utilization_ratio(robot As Integer, ByRef value As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_motor_torque(robot As Integer, value() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_hrss_version(robot As Integer, value As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_robot_type(robot As Integer, value As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_digital_setting(robot As Integer, index() As Integer, text As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_digital_setting(robot As Integer, index() As Integer, text As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_user_alarm_setting_message(robot As Integer, number As Integer, message As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_user_alarm_setting_message(robot As Integer, number As Integer, message As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_language(robot As Integer, language_number As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function SyncOutput(robot As Integer, type As Integer, id As Integer, on_off As Integer, synMode As Integer, delay As Integer, distance As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function save_module_io_setting(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_controller_time(robot As Integer, ByRef year As Integer, ByRef month As Integer, ByRef day As Integer, ByRef hour As Integer, ByRef minute As Integer, ByRef second As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_controller_time(robot As Integer, ByRef year As Integer, ByRef month As Integer, ByRef day As Integer, ByRef hour As Integer, ByRef minute As Integer, ByRef second As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_digital_input_comment(robot As Integer, di_index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_digital_input_comment(robot As Integer, di_index As Integer, comment() As UShort, array_size As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_digital_output_comment(robot As Integer, do_index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_digital_output_comment(robot As Integer, do_index As Integer, comment() As UShort, array_size As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_input_type(robot As Integer, index As Integer, type As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_module_output_type(robot As Integer, index As Integer, type As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function delete_file(robot As Integer, FilePath As String) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function delete_folder(robot As Integer, FilePath As String) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function new_folder(robot As Integer, FilePath As String) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function file_rename(robot As Integer, oldFilePath As String, newFilePath As String) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function file_drag(robot As Integer, fromFilePath As String, toFilePath As String) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_prog_number(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_prog_name(robot As Integer, file_index As Integer, file_name As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function enable_joint_soft_limit(robot As Integer, enable As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function enable_cart_soft_limit(robot As Integer, enable As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_joint_soft_limit(robot As Integer, low_limit() As Double, high_limit() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_cart_soft_limit(robot As Integer, low_limit() As Double, high_limit() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_joint_soft_limit_config(robot As Integer, ByRef enable As Boolean, low_limit() As Double, high_limit() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_cart_soft_limit_config(robot As Integer, ByRef enable As Boolean, low_limit() As Double, high_limit() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_network_show_msg(robot As Integer, enable As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_network_show_msg(robot As Integer, ByRef enable As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function network_connect(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function network_disconnect(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function network_send_msg(robot As Integer, msg As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function network_recieve_msg(robot As Integer, msg As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_network_config(robot As Integer, ByRef connect_type As Integer, msg As StringBuilder, ByRef port As Integer, ByRef bracket As Integer, ByRef separator As Integer, ByRef is_format As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_network_config(robot As Integer, connect_type As Integer, msg As StringBuilder, port As Integer, bracket As Integer, separator As Integer, is_format As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function network_change_ip(robot As Integer, lan_index As Integer, ip_type As Integer, ip_addr As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function network_get_state(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_payload_config(robot As Integer, index As Integer, value() As Double, comment As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_payload_config(robot As Integer, index As Integer, value() As Double, comment As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_payload_active(robot As Integer, ByRef index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_payload_active(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_robot_info(robot As Integer, page_sel As Integer, tool_num As Integer, base_num As Integer, info As StringBuilder, is_ready As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_ext_axis_setting(robot As Integer, index As Integer, enable As Boolean, mode As Integer, high_limit As Double, low_limit As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_ext_axis_setting(robot As Integer, index As Integer, enable As Boolean, mode As Integer, high_limit As Double, low_limit As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_ext_axis_setting_advanced(robot As Integer, index As Integer, _type As Integer, couple As Boolean, continuous As Boolean, int_data() As Integer, double_data() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_ext_axis_setting_advanced(robot As Integer, index As Integer, _type As Integer, couple As Boolean, continuous As Boolean, int_data() As Integer, double_data() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ext_mastering(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function confirm_home_point(robot As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_current_ext_pos(robot As Integer, pos() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_current_ext_mode(robot As Integer, mode As StringBuilder) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_home_warning_setting(robot As Integer, allow_error_value() As Double, allow_near_home() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_home_warning_setting(robot As Integer, allow_error_value() As Double, allow_near_home() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_previous_extpos(robot As Integer, ext_pos() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_ext_home_point(robot As Integer, ext_pos() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_ext_home_point(robot As Integer, ext_pos() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ext_ptp_axis(robot As Integer, mode As Integer, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ext_ptp_pos(robot As Integer, mode As Integer, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ext_lin_axis(robot As Integer, mode As Integer, smooth_value As Double, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function ext_lin_pos(robot As Integer, mode As Integer, smooth_value As Double, point() As Double) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_ext_driver_limit(robot As Integer, index As Integer, enable As Boolean, inverse As Boolean, negative_num As Integer, positive_num As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_ext_driver_limit(robot As Integer, index As Integer, ByRef enable As Boolean, ByRef inverse As Boolean, ByRef negative_num As Boolean, ByRef positive_num As Boolean, ByRef N_light As Boolean, ByRef P_light As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_ext_encoder(robot As Integer, value() As Int32) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_hrss_sdkver(robot As Integer, ByRef large_ver As Integer, ByRef small_ver As Integer, ByRef revision As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_hrsdk_sdkver(ByRef large_ver As Integer, ByRef small_ver As Integer, ByRef revision As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_fieldbus_input_comment(robot As Integer, index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_fieldbus_input_sim(robot As Integer, index As Integer, sim_status As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_fieldbus_output(robot As Integer, index As Integer, value As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_fieldbus_output_comment(robot As Integer, index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_fieldbus_rs_comment(robot As Integer, index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_fieldbus_rs_parameter(robot As Integer, index As Integer, parameter() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_fieldbus_rs_parameter(robot As Integer, index As Integer, parameter() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function clean_fieldbus_rs_parameter(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_base_name(robot As Integer, index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_tool_name(robot As Integer, index As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function clear_base_data(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function clear_tool_data(robot As Integer, index As Integer) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_error_msg(robot As Integer, comment() As UShort) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function set_home_setting_enable(robot As Integer, OnOff As Boolean) As Integer
    End Function
    <DllImport("HRSDK.dll")> Public Function get_robot_data(robot As Integer, sys_info() As Integer, port_info() As Integer, axis_info() As Double) As Integer
    End Function

    Public Enum ConnectionLevels As Integer
        kDisconnection = -1
        kMonitor = 0
        kController
    End Enum

    Public Enum OperationModes As Integer
        kManual = 0
        kAuto
    End Enum

    Public Enum SpaceOperationTypes As Integer
        kCartesian = 0
        kJoint
        kTool
    End Enum

    Public Enum SpaceOperationDirection As Integer
        kPositive = 1
        kNegative = -1
    End Enum

    Public Enum JointCoordinates As Integer
        kJoint1 = 0
        kJoint2
        kJoint3
        kJoint4
        kJoint5
        kJoint
    End Enum

    Public Enum CartesianCoordinates As Integer
        kCartesianX = 0
        kCartesianY
        kCartesianZ
        kCartesianA
        kCartesianB
        kCartesianC
    End Enum
    Public Enum RobotMotionStatus As Integer
        kIdle = 1
        kRunning
        kHold
        kDelay
        kWait
    End Enum

    Function FunctionFeedback(FunCode As Integer) As String
        ' Returns a string which includes title and text of a MsgBox which provides the feedback of a HRSDK command

        Dim res As String
        Dim prompt As String = String.Empty
        Dim title As String = String.Empty

        Select Case FunCode
            Case -11
                prompt = "Command execution failed"
                title = "Failed"
            Case -1
                prompt = "Command execution failed"
                title = "Failed"
            Case -2
                prompt = "Return mechanism creation failed"
                title = "Failed"
            Case -3
                prompt = "Cannot connect to robot"
                title = "Failed"
            Case -4
                prompt = "HRSDK and HRSS version mismatch"
                title = "Failed"
            Case 0
                prompt = "Command completed normally"
                title = "Normal"
            Case 49
                prompt = "The new password set for change password cannot be empty or special characters"
                title = "No new password"
            Case 50
                prompt = "Wrong password entered"
                title = "Password error"
            Case 100
                prompt = "Authorization failed; please contact customer service personnel"
                title = "Unauthorized"
            Case 110
                prompt = "This connection was interrupted"
                title = "Disconnected"
            Case 150
                prompt = "Articulated robot currently has no files executing"
                title = "No file is executing"
            Case 200
                prompt = "File open failed or file name error; please confirm whether the file path is correct"
                title = "File open failed"
            Case 201
                prompt = "File does not exist; please confirm whether the file path is correct"
                title = "File does not exist"
            Case 202
                prompt = "Network communication abnormal"
                title = "File send error"
            Case 206
                prompt = "Transferred file is too big or file transfer channel abnormal"
                title = "File communication error"
            Case 207
                prompt = "File transfer channel abnormal"
                title = "Received file packet abnormal"
            Case 208
                prompt = "Write error occurs when there is a problem with the file transfer"
                title = "File write error"
            Case 209
                prompt = "Transferred file is too big or file transfer channel abnormal"
                title = "File download timeout"
            Case 210
                prompt = "Please confirm whether the file name includes special characters"
                title = "File name error"
            Case 211
                prompt = "File name too long"
                title = "File name too long"
            Case 212
                prompt = "Transfer command timeout; connection abnormal or extend command transfer intervals"
                title = "Command timeout"
            Case 300
                prompt = "No alarms occurred, cannot clear alarm"
                title = "No alarms occurred"
            Case 2000
                prompt = "Cannot execute requested command"
                title = "Cannot execute"
            Case 2004
                prompt = "Command parameter error"
                title = "Parameter error"
            Case 2005
                prompt = "Command execution became abnormal"
                title = "Command execution abnormal"
            Case 2006
                prompt = "Does not accept the execution of commands based on the system status"
                title = "Cannot accept command"
            Case 2007
                prompt = "The length of the string entered is too long"
                title = "String too long"
            Case 2008
                prompt = "Current status is not in EXT mode"
                title = "Mode error"
            Case 2009
                prompt = "Number of send command and receive command is not consistent; please send again"
                title = "Command inconsistent"
            Case 2100
                prompt = "Controller already exists"
                title = "Controller already exists"
            Case 3000
                prompt = "Problems occurred for network communication, command receive/send error"
                title = "Command transfer error"
            Case 3001
                prompt = "Problems occurred for network communication"
                title = "Command receive error"
            Case 3100
                prompt = "The IO set is already used"
                title = "IO used"
            Case 4000
                prompt = "The current mode does not accept the execution of commands"
                title = "Mode prohibition"
            Case 4001
                prompt = "This command cannot be executed under the non-excited status"
                title = "Servo prohibition"
            Case 4003
                prompt = "When the number of motion register reaches 1000 entries, the requested command cannot be executed"
                title = "Motion register prohibition"
            Case 4005
                prompt = "Instruction sent cannot be executed because the external axis was not enabled"
                title = "External axis not enabled"
            Case 4010
                prompt = "RSR/PNS task setting abnormal"
                title = "File execution abnormal"
            Case 4011
                prompt = "RSR/PNS task execution failed"
                title = "File execution abnormal"
            Case 4012
                prompt = "Task name error or missing"
                title = "File execution abnormal"
            Case 4013
                prompt = "There already is task executing"
                title = "File execution abnormal"
            Case 4020
                prompt = "Update file failed"
                title = "Update file abnormal"
            Case 4021
                prompt = "Update file send failed"
                title = "Update file abnormal"
            Case 4022
                prompt = "Update file receive failed"
                title = "Update file abnormal"
            Case 4023
                prompt = "HRSS has insufficient hard drive space; please delete unnecessary files"
                title = "Update file abnormal"
            Case 4024
                prompt = "HRSS update file does not exist; please confirm whether the file path is correct"
                title = "Update file abnormal"
            Case 9999
                prompt = "This function is abnormal"
                title = "Function abnormal"
        End Select

        MsgBox(prompt, MsgBoxStyle.Information, title)
        res = title & "|" & prompt
        Return res

    End Function

End Module