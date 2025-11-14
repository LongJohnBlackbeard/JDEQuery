using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q11 - .
/// </summary>
public class F43Q11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDEVNU.
        /// </summary>
        public const string EDEVNU = "EDEVNU";

        /// <summary>
        /// EDDCTO.
        /// </summary>
        public const string EDDCTO = "EDDCTO";

        /// <summary>
        /// EDKCOO.
        /// </summary>
        public const string EDKCOO = "EDKCOO";

        /// <summary>
        /// EDEVLN.
        /// </summary>
        public const string EDEVLN = "EDEVLN";

        /// <summary>
        /// EDMCU.
        /// </summary>
        public const string EDMCU = "EDMCU";

        /// <summary>
        /// EDQRQD.
        /// </summary>
        public const string EDQRQD = "EDQRQD";

        /// <summary>
        /// EDITM.
        /// </summary>
        public const string EDITM = "EDITM";

        /// <summary>
        /// EDAITM.
        /// </summary>
        public const string EDAITM = "EDAITM";

        /// <summary>
        /// EDLITM.
        /// </summary>
        public const string EDLITM = "EDLITM";

        /// <summary>
        /// EDLNTY.
        /// </summary>
        public const string EDLNTY = "EDLNTY";

        /// <summary>
        /// EDGLPT.
        /// </summary>
        public const string EDGLPT = "EDGLPT";

        /// <summary>
        /// EDANI.
        /// </summary>
        public const string EDANI = "EDANI";

        /// <summary>
        /// EDAID.
        /// </summary>
        public const string EDAID = "EDAID";

        /// <summary>
        /// EDOMCU.
        /// </summary>
        public const string EDOMCU = "EDOMCU";

        /// <summary>
        /// EDOBJ.
        /// </summary>
        public const string EDOBJ = "EDOBJ";

        /// <summary>
        /// EDSUB.
        /// </summary>
        public const string EDSUB = "EDSUB";

        /// <summary>
        /// EDSBLT.
        /// </summary>
        public const string EDSBLT = "EDSBLT";

        /// <summary>
        /// EDSBL.
        /// </summary>
        public const string EDSBL = "EDSBL";

        /// <summary>
        /// EDASID.
        /// </summary>
        public const string EDASID = "EDASID";

        /// <summary>
        /// EDUOM.
        /// </summary>
        public const string EDUOM = "EDUOM";

        /// <summary>
        /// EDDSC1.
        /// </summary>
        public const string EDDSC1 = "EDDSC1";

        /// <summary>
        /// EDMINQTY.
        /// </summary>
        public const string EDMINQTY = "EDMINQTY";

        /// <summary>
        /// EDMAXQTY.
        /// </summary>
        public const string EDMAXQTY = "EDMAXQTY";

        /// <summary>
        /// EDUORG.
        /// </summary>
        public const string EDUORG = "EDUORG";

        /// <summary>
        /// EDEVSP.
        /// </summary>
        public const string EDEVSP = "EDEVSP";

        /// <summary>
        /// EDAEXP.
        /// </summary>
        public const string EDAEXP = "EDAEXP";

        /// <summary>
        /// EDEVLS.
        /// </summary>
        public const string EDEVLS = "EDEVLS";

        /// <summary>
        /// EDELQA.
        /// </summary>
        public const string EDELQA = "EDELQA";

        /// <summary>
        /// EDELQP.
        /// </summary>
        public const string EDELQP = "EDELQP";

        /// <summary>
        /// EDLNWT.
        /// </summary>
        public const string EDLNWT = "EDLNWT";

        /// <summary>
        /// EDVR01.
        /// </summary>
        public const string EDVR01 = "EDVR01";

        /// <summary>
        /// EDDRQJ.
        /// </summary>
        public const string EDDRQJ = "EDDRQJ";

        /// <summary>
        /// EDFRTH.
        /// </summary>
        public const string EDFRTH = "EDFRTH";

        /// <summary>
        /// EDMOT.
        /// </summary>
        public const string EDMOT = "EDMOT";

        /// <summary>
        /// EDSHAN.
        /// </summary>
        public const string EDSHAN = "EDSHAN";

        /// <summary>
        /// EDINMG.
        /// </summary>
        public const string EDINMG = "EDINMG";

        /// <summary>
        /// EDITVL.
        /// </summary>
        public const string EDITVL = "EDITVL";

        /// <summary>
        /// EDVLUM.
        /// </summary>
        public const string EDVLUM = "EDVLUM";

        /// <summary>
        /// EDITWT.
        /// </summary>
        public const string EDITWT = "EDITWT";

        /// <summary>
        /// EDWTUM.
        /// </summary>
        public const string EDWTUM = "EDWTUM";

        /// <summary>
        /// EDURCD.
        /// </summary>
        public const string EDURCD = "EDURCD";

        /// <summary>
        /// EDURDT.
        /// </summary>
        public const string EDURDT = "EDURDT";

        /// <summary>
        /// EDURAT.
        /// </summary>
        public const string EDURAT = "EDURAT";

        /// <summary>
        /// EDURAB.
        /// </summary>
        public const string EDURAB = "EDURAB";

        /// <summary>
        /// EDURRF.
        /// </summary>
        public const string EDURRF = "EDURRF";

        /// <summary>
        /// EDTORG.
        /// </summary>
        public const string EDTORG = "EDTORG";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDTDAY.
        /// </summary>
        public const string EDTDAY = "EDTDAY";

        /// <summary>
        /// EDCMDCDE.
        /// </summary>
        public const string EDCMDCDE = "EDCMDCDE";

        /// <summary>
        /// EDCCUKID.
        /// </summary>
        public const string EDCCUKID = "EDCCUKID";

        /// <summary>
        /// EDABV.
        /// </summary>
        public const string EDABV = "EDABV";

        /// <summary>
        /// EDRLQROL.
        /// </summary>
        public const string EDRLQROL = "EDRLQROL";

        /// <summary>
        /// EDREVPR.
        /// </summary>
        public const string EDREVPR = "EDREVPR";

        /// <summary>
        /// EDBROL.
        /// </summary>
        public const string EDBROL = "EDBROL";

        /// <summary>
        /// EDIVI.
        /// </summary>
        public const string EDIVI = "EDIVI";

        /// <summary>
        /// EDPRP1.
        /// </summary>
        public const string EDPRP1 = "EDPRP1";

        /// <summary>
        /// EDPRP2.
        /// </summary>
        public const string EDPRP2 = "EDPRP2";

        /// <summary>
        /// EDPRP4.
        /// </summary>
        public const string EDPRP4 = "EDPRP4";

        /// <summary>
        /// EDPRP3.
        /// </summary>
        public const string EDPRP3 = "EDPRP3";

        /// <summary>
        /// EDPRP5.
        /// </summary>
        public const string EDPRP5 = "EDPRP5";

        /// <summary>
        /// EDADDITEM.
        /// </summary>
        public const string EDADDITEM = "EDADDITEM";

        /// <summary>
        /// EDTQW.
        /// </summary>
        public const string EDTQW = "EDTQW";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDEVNU", "EDEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("EDDCTO", "EDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("EDKCOO", "EDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("EDEVLN", "EDEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDMCU", "EDMCU", JdeDataType.String, 24),
        new JdeField("EDQRQD", "EDQRQD", JdeDataType.String, 2),
        new JdeField("EDITM", "EDITM", JdeDataType.Numeric),
        new JdeField("EDAITM", "EDAITM", JdeDataType.String, 50),
        new JdeField("EDLITM", "EDLITM", JdeDataType.String, 50),
        new JdeField("EDLNTY", "EDLNTY", JdeDataType.String, 4),
        new JdeField("EDGLPT", "EDGLPT", JdeDataType.String, 8),
        new JdeField("EDANI", "EDANI", JdeDataType.String, 58),
        new JdeField("EDAID", "EDAID", JdeDataType.String, 16),
        new JdeField("EDOMCU", "EDOMCU", JdeDataType.String, 24),
        new JdeField("EDOBJ", "EDOBJ", JdeDataType.String, 12),
        new JdeField("EDSUB", "EDSUB", JdeDataType.String, 16),
        new JdeField("EDSBLT", "EDSBLT", JdeDataType.String, 2),
        new JdeField("EDSBL", "EDSBL", JdeDataType.String, 16),
        new JdeField("EDASID", "EDASID", JdeDataType.String, 50),
        new JdeField("EDUOM", "EDUOM", JdeDataType.String, 4),
        new JdeField("EDDSC1", "EDDSC1", JdeDataType.String, 60),
        new JdeField("EDMINQTY", "EDMINQTY", JdeDataType.Numeric),
        new JdeField("EDMAXQTY", "EDMAXQTY", JdeDataType.Numeric),
        new JdeField("EDUORG", "EDUORG", JdeDataType.Numeric),
        new JdeField("EDEVSP", "EDEVSP", JdeDataType.Numeric),
        new JdeField("EDAEXP", "EDAEXP", JdeDataType.Numeric),
        new JdeField("EDEVLS", "EDEVLS", JdeDataType.String, 4),
        new JdeField("EDELQA", "EDELQA", JdeDataType.Numeric),
        new JdeField("EDELQP", "EDELQP", JdeDataType.Numeric),
        new JdeField("EDLNWT", "EDLNWT", JdeDataType.Numeric),
        new JdeField("EDVR01", "EDVR01", JdeDataType.String, 50),
        new JdeField("EDDRQJ", "EDDRQJ", JdeDataType.Numeric),
        new JdeField("EDFRTH", "EDFRTH", JdeDataType.String, 6),
        new JdeField("EDMOT", "EDMOT", JdeDataType.String, 6),
        new JdeField("EDSHAN", "EDSHAN", JdeDataType.Numeric),
        new JdeField("EDINMG", "EDINMG", JdeDataType.String, 20),
        new JdeField("EDITVL", "EDITVL", JdeDataType.Numeric),
        new JdeField("EDVLUM", "EDVLUM", JdeDataType.String, 4),
        new JdeField("EDITWT", "EDITWT", JdeDataType.Numeric),
        new JdeField("EDWTUM", "EDWTUM", JdeDataType.String, 4),
        new JdeField("EDURCD", "EDURCD", JdeDataType.String, 4),
        new JdeField("EDURDT", "EDURDT", JdeDataType.Numeric),
        new JdeField("EDURAT", "EDURAT", JdeDataType.Numeric),
        new JdeField("EDURAB", "EDURAB", JdeDataType.Numeric),
        new JdeField("EDURRF", "EDURRF", JdeDataType.String, 30),
        new JdeField("EDTORG", "EDTORG", JdeDataType.String, 20),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDTDAY", "EDTDAY", JdeDataType.Numeric),
        new JdeField("EDCMDCDE", "EDCMDCDE", JdeDataType.String, 30),
        new JdeField("EDCCUKID", "EDCCUKID", JdeDataType.Numeric),
        new JdeField("EDABV", "EDABV", JdeDataType.String, 2),
        new JdeField("EDRLQROL", "EDRLQROL", JdeDataType.String, 2),
        new JdeField("EDREVPR", "EDREVPR", JdeDataType.Numeric),
        new JdeField("EDBROL", "EDBROL", JdeDataType.String, 2),
        new JdeField("EDIVI", "EDIVI", JdeDataType.String, 2),
        new JdeField("EDPRP1", "EDPRP1", JdeDataType.String, 6),
        new JdeField("EDPRP2", "EDPRP2", JdeDataType.String, 6),
        new JdeField("EDPRP4", "EDPRP4", JdeDataType.String, 6),
        new JdeField("EDPRP3", "EDPRP3", JdeDataType.String, 6),
        new JdeField("EDPRP5", "EDPRP5", JdeDataType.String, 6),
        new JdeField("EDADDITEM", "EDADDITEM", JdeDataType.String, 4),
        new JdeField("EDTQW", "EDTQW", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q11_0", "Primary Key on EDEVNU, EDDCTO, EDKCOO, EDEVLN", new[] { "EDEVNU", "EDDCTO", "EDKCOO", "EDEVLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q11_2", "Index on EDEVNU, EDDCTO, EDKCOO", new[] { "EDEVNU", "EDDCTO", "EDKCOO" })
    };
}
