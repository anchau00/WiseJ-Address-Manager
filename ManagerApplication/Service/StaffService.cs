using System.Collections.Generic;
using System;
public class StaffService {
    private StaffDatabase staffdb;

    public StaffService() {
        staffdb = new StaffDatabase(); 
    }

    public void addStaff(Staff staff) {
        staffdb.insertStaff(staff);
    }

    public void updateStaff(Staff staff){
         staffdb.updateStaff(staff);
    }

    
    public void deleteStaff(int id){
         staffdb.deleteStaff(id);
    }

    public List<Staff> GetAllStaff(){
        return staffdb.GetAllStaff();
    }


}
