using System.Collections.Generic;
using System;
public class StaffControl{

    private StaffService staffServ;

    public StaffControl(){
        staffServ = new StaffService();
    }

    
    public void addStaff(Staff staff) {
        staffServ.addStaff(staff);
    }

    public void updateStaff(Staff staff){
         staffServ.updateStaff(staff);
    }

    
    public void deleteStaff(int id){
         staffServ.deleteStaff(id);
    }

    public List<Staff> GetAllStaff(){
        return staffServ.GetAllStaff();
    }





}