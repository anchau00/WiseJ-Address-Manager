using System.Collections.Generic;
using System;
public class OrgService {
    private OrgDatabase orgdb;

    public OrgService() {
        orgdb = new OrgDatabase(); 
    }

    public void addOrg(Organization org) {
        orgdb.insertOrg(org);
    }

    public void updateOrg(Organization org){
        orgdb.updateOrg(org);
    }

    public void deleteOrg(int id){
        orgdb.deleteOrg(id);
    }

    public List<Organization> GetAllOrganizations(){
        return orgdb.GetAllOrganizations();
    }


}
