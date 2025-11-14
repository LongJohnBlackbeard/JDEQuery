using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q21 - .
/// </summary>
public class F43Q21 : JdeTable
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
        /// EDBIDQN.
        /// </summary>
        public const string EDBIDQN = "EDBIDQN";

        /// <summary>
        /// EDBIDCODE.
        /// </summary>
        public const string EDBIDCODE = "EDBIDCODE";

        /// <summary>
        /// EDDESC.
        /// </summary>
        public const string EDDESC = "EDDESC";

        /// <summary>
        /// EDBQTYP.
        /// </summary>
        public const string EDBQTYP = "EDBQTYP";

        /// <summary>
        /// EDBIDQUES.
        /// </summary>
        public const string EDBIDQUES = "EDBIDQUES";

        /// <summary>
        /// EDUOM.
        /// </summary>
        public const string EDUOM = "EDUOM";

        /// <summary>
        /// EDWSTQ.
        /// </summary>
        public const string EDWSTQ = "EDWSTQ";

        /// <summary>
        /// EDBESTQTY.
        /// </summary>
        public const string EDBESTQTY = "EDBESTQTY";

        /// <summary>
        /// EDBESTAMT.
        /// </summary>
        public const string EDBESTAMT = "EDBESTAMT";

        /// <summary>
        /// EDWSAMT.
        /// </summary>
        public const string EDWSAMT = "EDWSAMT";

        /// <summary>
        /// EDWDAT.
        /// </summary>
        public const string EDWDAT = "EDWDAT";

        /// <summary>
        /// EDBESTDATE.
        /// </summary>
        public const string EDBESTDATE = "EDBESTDATE";

        /// <summary>
        /// EDIDTX.
        /// </summary>
        public const string EDIDTX = "EDIDTX";

        /// <summary>
        /// EDIYON.
        /// </summary>
        public const string EDIYON = "EDIYON";

        /// <summary>
        /// EDDBQR.
        /// </summary>
        public const string EDDBQR = "EDDBQR";

        /// <summary>
        /// EDOUTRANGE.
        /// </summary>
        public const string EDOUTRANGE = "EDOUTRANGE";

        /// <summary>
        /// EDWHTG.
        /// </summary>
        public const string EDWHTG = "EDWHTG";

        /// <summary>
        /// EDDISBDQ.
        /// </summary>
        public const string EDDISBDQ = "EDDISBDQ";

        /// <summary>
        /// EDBQO.
        /// </summary>
        public const string EDBQO = "EDBQO";

        /// <summary>
        /// EDBRQD.
        /// </summary>
        public const string EDBRQD = "EDBRQD";

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
        /// EDPBRS.
        /// </summary>
        public const string EDPBRS = "EDPBRS";

        /// <summary>
        /// EDPCRS.
        /// </summary>
        public const string EDPCRS = "EDPCRS";

        /// <summary>
        /// EDBPRICE.
        /// </summary>
        public const string EDBPRICE = "EDBPRICE";

        /// <summary>
        /// EDWPRICE.
        /// </summary>
        public const string EDWPRICE = "EDWPRICE";

        /// <summary>
        /// EDCMDCDE.
        /// </summary>
        public const string EDCMDCDE = "EDCMDCDE";

        /// <summary>
        /// EDMULTSEL.
        /// </summary>
        public const string EDMULTSEL = "EDMULTSEL";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDEVNU", "EDEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("EDDCTO", "EDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("EDKCOO", "EDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("EDEVLN", "EDEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDBIDQN", "EDBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDBIDCODE", "EDBIDCODE", JdeDataType.String, 36),
        new JdeField("EDDESC", "EDDESC", JdeDataType.String, 60),
        new JdeField("EDBQTYP", "EDBQTYP", JdeDataType.String, 4),
        new JdeField("EDBIDQUES", "EDBIDQUES", JdeDataType.String, 3998),
        new JdeField("EDUOM", "EDUOM", JdeDataType.String, 4),
        new JdeField("EDWSTQ", "EDWSTQ", JdeDataType.Numeric),
        new JdeField("EDBESTQTY", "EDBESTQTY", JdeDataType.Numeric),
        new JdeField("EDBESTAMT", "EDBESTAMT", JdeDataType.Numeric),
        new JdeField("EDWSAMT", "EDWSAMT", JdeDataType.Numeric),
        new JdeField("EDWDAT", "EDWDAT", JdeDataType.Numeric),
        new JdeField("EDBESTDATE", "EDBESTDATE", JdeDataType.Numeric),
        new JdeField("EDIDTX", "EDIDTX", JdeDataType.String, 1000),
        new JdeField("EDIYON", "EDIYON", JdeDataType.String, 2),
        new JdeField("EDDBQR", "EDDBQR", JdeDataType.String, 2),
        new JdeField("EDOUTRANGE", "EDOUTRANGE", JdeDataType.String, 2),
        new JdeField("EDWHTG", "EDWHTG", JdeDataType.Numeric),
        new JdeField("EDDISBDQ", "EDDISBDQ", JdeDataType.String, 2),
        new JdeField("EDBQO", "EDBQO", JdeDataType.String, 2),
        new JdeField("EDBRQD", "EDBRQD", JdeDataType.String, 2),
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
        new JdeField("EDPBRS", "EDPBRS", JdeDataType.String, 2),
        new JdeField("EDPCRS", "EDPCRS", JdeDataType.String, 2),
        new JdeField("EDBPRICE", "EDBPRICE", JdeDataType.Numeric),
        new JdeField("EDWPRICE", "EDWPRICE", JdeDataType.Numeric),
        new JdeField("EDCMDCDE", "EDCMDCDE", JdeDataType.String, 30),
        new JdeField("EDMULTSEL", "EDMULTSEL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q21_0", "Primary Key on EDEVNU, EDDCTO, EDKCOO, EDEVLN, EDBIDQN", new[] { "EDEVNU", "EDDCTO", "EDKCOO", "EDEVLN", "EDBIDQN" }, isUnique: true, isPrimaryKey: true)
    };
}
