using System;
public class ContactDetail
{
    private long _mobile;
    private long _alternateMobile;
    private long _landLine;
    private string _email;
    private string _address;
    public ContactDetail(long mobile,long alternateMobile,long landLine,string email,string address)
    {
        this._mobile = mobile;
        this._alternateMobile = alternateMobile;
        this._landLine = landLine;
        this._email = email;
        this._address = address;
    }
    public long Mobile
    {
        get{
            return this._mobile;
        }
        set{
            this._mobile = value;
        }
    }
    public long AlternateMobile
    {
        get{
            return this._alternateMobile;
        }
        set{
            this._alternateMobile = value;
        }
    }
    public long LandLine
    {
        get{
            return this._landLine;
        }
        set{
            this._landLine = value;
        }
    }
    public string Email
    {
        get{
            return this._email;
        }
        set{
            this._email = value;
        }
    }
    public string Address
    {
        get{
            return this._address;
        }
        set{
            this._address = value;
        }
    }
     public override String ToString()
    {
        //Fill your code
        return string.Format("Contact Details\nMobile:{0}\nAlternate Mobile:{1}\nLandLine:{2}\nEmail Id:{3}\nAddress:{4}",_mobile,_alternateMobile,_landLine,_email,_address);
    }
}
