using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q51 - .
/// </summary>
public class F43Q51 : JdeTable
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
        /// EDAN8.
        /// </summary>
        public const string EDAN8 = "EDAN8";

        /// <summary>
        /// EDBIDNUM.
        /// </summary>
        public const string EDBIDNUM = "EDBIDNUM";

        /// <summary>
        /// EDAWARDNUM.
        /// </summary>
        public const string EDAWARDNUM = "EDAWARDNUM";

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
        /// EDUOM.
        /// </summary>
        public const string EDUOM = "EDUOM";

        /// <summary>
        /// EDDSC1.
        /// </summary>
        public const string EDDSC1 = "EDDSC1";

        /// <summary>
        /// EDAWARDQTY.
        /// </summary>
        public const string EDAWARDQTY = "EDAWARDQTY";

        /// <summary>
        /// EDAMTONLY.
        /// </summary>
        public const string EDAMTONLY = "EDAMTONLY";

        /// <summary>
        /// EDUORG.
        /// </summary>
        public const string EDUORG = "EDUORG";

        /// <summary>
        /// EDCRCD.
        /// </summary>
        public const string EDCRCD = "EDCRCD";

        /// <summary>
        /// EDLBUA.
        /// </summary>
        public const string EDLBUA = "EDLBUA";

        /// <summary>
        /// EDLBEA.
        /// </summary>
        public const string EDLBEA = "EDLBEA";

        /// <summary>
        /// EDLFUA.
        /// </summary>
        public const string EDLFUA = "EDLFUA";

        /// <summary>
        /// EDLFEA.
        /// </summary>
        public const string EDLFEA = "EDLFEA";

        /// <summary>
        /// EDLBQS.
        /// </summary>
        public const string EDLBQS = "EDLBQS";

        /// <summary>
        /// EDAWARDACT.
        /// </summary>
        public const string EDAWARDACT = "EDAWARDACT";

        /// <summary>
        /// EDRCD.
        /// </summary>
        public const string EDRCD = "EDRCD";

        /// <summary>
        /// EDPCAW.
        /// </summary>
        public const string EDPCAW = "EDPCAW";

        /// <summary>
        /// EDPBRS.
        /// </summary>
        public const string EDPBRS = "EDPBRS";

        /// <summary>
        /// EDADDITEM.
        /// </summary>
        public const string EDADDITEM = "EDADDITEM";

        /// <summary>
        /// EDLNID.
        /// </summary>
        public const string EDLNID = "EDLNID";

        /// <summary>
        /// EDPDDJ.
        /// </summary>
        public const string EDPDDJ = "EDPDDJ";

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
    }

    /// <inheritdoc />
    public override string TableName => "F43Q51";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDEVNU", "EDEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("EDDCTO", "EDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("EDKCOO", "EDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("EDEVLN", "EDEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDAN8", "EDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EDBIDNUM", "EDBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("EDAWARDNUM", "EDAWARDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("EDITM", "EDITM", JdeDataType.Numeric),
        new JdeField("EDAITM", "EDAITM", JdeDataType.String, 50),
        new JdeField("EDLITM", "EDLITM", JdeDataType.String, 50),
        new JdeField("EDUOM", "EDUOM", JdeDataType.String, 4),
        new JdeField("EDDSC1", "EDDSC1", JdeDataType.String, 60),
        new JdeField("EDAWARDQTY", "EDAWARDQTY", JdeDataType.Numeric),
        new JdeField("EDAMTONLY", "EDAMTONLY", JdeDataType.String, 2),
        new JdeField("EDUORG", "EDUORG", JdeDataType.Numeric),
        new JdeField("EDCRCD", "EDCRCD", JdeDataType.String, 6),
        new JdeField("EDLBUA", "EDLBUA", JdeDataType.Numeric),
        new JdeField("EDLBEA", "EDLBEA", JdeDataType.Numeric),
        new JdeField("EDLFUA", "EDLFUA", JdeDataType.Numeric),
        new JdeField("EDLFEA", "EDLFEA", JdeDataType.Numeric),
        new JdeField("EDLBQS", "EDLBQS", JdeDataType.Numeric),
        new JdeField("EDAWARDACT", "EDAWARDACT", JdeDataType.String, 4),
        new JdeField("EDRCD", "EDRCD", JdeDataType.String, 6),
        new JdeField("EDPCAW", "EDPCAW", JdeDataType.Numeric),
        new JdeField("EDPBRS", "EDPBRS", JdeDataType.String, 2),
        new JdeField("EDADDITEM", "EDADDITEM", JdeDataType.String, 4),
        new JdeField("EDLNID", "EDLNID", JdeDataType.Numeric),
        new JdeField("EDPDDJ", "EDPDDJ", JdeDataType.Numeric),
        new JdeField("EDFRTH", "EDFRTH", JdeDataType.String, 6),
        new JdeField("EDMOT", "EDMOT", JdeDataType.String, 6),
        new JdeField("EDSHAN", "EDSHAN", JdeDataType.Numeric),
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
        new JdeField("EDTDAY", "EDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q51_0", "Primary Key on EDEVNU, EDDCTO, EDKCOO, EDEVLN, EDAN8, EDBIDNUM, EDAWARDNUM", new[] { "EDEVNU", "EDDCTO", "EDKCOO", "EDEVLN", "EDAN8", "EDBIDNUM", "EDAWARDNUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q51_2", "Index on EDEVNU, EDDCTO, EDKCOO, EDAN8, EDBIDNUM, EDAWARDNUM, EDEVLN", new[] { "EDEVNU", "EDDCTO", "EDKCOO", "EDAN8", "EDBIDNUM", "EDAWARDNUM", "EDEVLN" }),
        new JdeIndex("F43Q51_3", "Index on EDEVNU, EDDCTO, EDKCOO, EDAN8, EDBIDNUM, EDEVLN, EDAWARDNUM", new[] { "EDEVNU", "EDDCTO", "EDKCOO", "EDAN8", "EDBIDNUM", "EDEVLN", "EDAWARDNUM" })
    };
}
