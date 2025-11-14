using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277709 - .
/// </summary>
public class F4277709 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HHKCOO.
        /// </summary>
        public const string HHKCOO = "HHKCOO";

        /// <summary>
        /// HHDOCO.
        /// </summary>
        public const string HHDOCO = "HHDOCO";

        /// <summary>
        /// HHDCTO.
        /// </summary>
        public const string HHDCTO = "HHDCTO";

        /// <summary>
        /// HHORMNFLPR.
        /// </summary>
        public const string HHORMNFLPR = "HHORMNFLPR";

        /// <summary>
        /// HHSLOVRCD.
        /// </summary>
        public const string HHSLOVRCD = "HHSLOVRCD";

        /// <summary>
        /// HHOMFPLNID.
        /// </summary>
        public const string HHOMFPLNID = "HHOMFPLNID";

        /// <summary>
        /// HHSLCUSTFN.
        /// </summary>
        public const string HHSLCUSTFN = "HHSLCUSTFN";

        /// <summary>
        /// HHSLCFLNID.
        /// </summary>
        public const string HHSLCFLNID = "HHSLCFLNID";

        /// <summary>
        /// HHORDRELSD.
        /// </summary>
        public const string HHORDRELSD = "HHORDRELSD";

        /// <summary>
        /// HHORDSLMET.
        /// </summary>
        public const string HHORDSLMET = "HHORDSLMET";

        /// <summary>
        /// HHSLMTRLCH.
        /// </summary>
        public const string HHSLMTRLCH = "HHSLMTRLCH";

        /// <summary>
        /// HHSLRCHAR1.
        /// </summary>
        public const string HHSLRCHAR1 = "HHSLRCHAR1";

        /// <summary>
        /// HHSLRCHAR2.
        /// </summary>
        public const string HHSLRCHAR2 = "HHSLRCHAR2";

        /// <summary>
        /// HHSLRCHAR3.
        /// </summary>
        public const string HHSLRCHAR3 = "HHSLRCHAR3";

        /// <summary>
        /// HHSLRSTRG1.
        /// </summary>
        public const string HHSLRSTRG1 = "HHSLRSTRG1";

        /// <summary>
        /// HHSLRSTRG2.
        /// </summary>
        public const string HHSLRSTRG2 = "HHSLRSTRG2";

        /// <summary>
        /// HHSLRSTRG3.
        /// </summary>
        public const string HHSLRSTRG3 = "HHSLRSTRG3";

        /// <summary>
        /// HHSLRAMNT1.
        /// </summary>
        public const string HHSLRAMNT1 = "HHSLRAMNT1";

        /// <summary>
        /// HHSLRAMNT2.
        /// </summary>
        public const string HHSLRAMNT2 = "HHSLRAMNT2";

        /// <summary>
        /// HHSLRAMNT3.
        /// </summary>
        public const string HHSLRAMNT3 = "HHSLRAMNT3";

        /// <summary>
        /// HHSLRNUMB1.
        /// </summary>
        public const string HHSLRNUMB1 = "HHSLRNUMB1";

        /// <summary>
        /// HHSLRNUMB2.
        /// </summary>
        public const string HHSLRNUMB2 = "HHSLRNUMB2";

        /// <summary>
        /// HHSLRNUMB3.
        /// </summary>
        public const string HHSLRNUMB3 = "HHSLRNUMB3";

        /// <summary>
        /// HHSLRDATE1.
        /// </summary>
        public const string HHSLRDATE1 = "HHSLRDATE1";

        /// <summary>
        /// HHSLRDATE2.
        /// </summary>
        public const string HHSLRDATE2 = "HHSLRDATE2";

        /// <summary>
        /// HHSLRDATE3.
        /// </summary>
        public const string HHSLRDATE3 = "HHSLRDATE3";

        /// <summary>
        /// HHSLRCODE1.
        /// </summary>
        public const string HHSLRCODE1 = "HHSLRCODE1";

        /// <summary>
        /// HHSLRCODE2.
        /// </summary>
        public const string HHSLRCODE2 = "HHSLRCODE2";

        /// <summary>
        /// HHSLRCODE3.
        /// </summary>
        public const string HHSLRCODE3 = "HHSLRCODE3";

        /// <summary>
        /// HHURCD.
        /// </summary>
        public const string HHURCD = "HHURCD";

        /// <summary>
        /// HHURDT.
        /// </summary>
        public const string HHURDT = "HHURDT";

        /// <summary>
        /// HHURAT.
        /// </summary>
        public const string HHURAT = "HHURAT";

        /// <summary>
        /// HHURAB.
        /// </summary>
        public const string HHURAB = "HHURAB";

        /// <summary>
        /// HHURRF.
        /// </summary>
        public const string HHURRF = "HHURRF";

        /// <summary>
        /// HHUSER.
        /// </summary>
        public const string HHUSER = "HHUSER";

        /// <summary>
        /// HHPID.
        /// </summary>
        public const string HHPID = "HHPID";

        /// <summary>
        /// HHJOBN.
        /// </summary>
        public const string HHJOBN = "HHJOBN";

        /// <summary>
        /// HHUPMJ.
        /// </summary>
        public const string HHUPMJ = "HHUPMJ";

        /// <summary>
        /// HHTDAY.
        /// </summary>
        public const string HHTDAY = "HHTDAY";

        /// <summary>
        /// HHUTIME.
        /// </summary>
        public const string HHUTIME = "HHUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4277709";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HHKCOO", "HHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("HHDOCO", "HHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("HHDCTO", "HHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("HHORMNFLPR", "HHORMNFLPR", JdeDataType.Numeric),
        new JdeField("HHSLOVRCD", "HHSLOVRCD", JdeDataType.String, 6),
        new JdeField("HHOMFPLNID", "HHOMFPLNID", JdeDataType.Numeric),
        new JdeField("HHSLCUSTFN", "HHSLCUSTFN", JdeDataType.String, 64),
        new JdeField("HHSLCFLNID", "HHSLCFLNID", JdeDataType.Numeric),
        new JdeField("HHORDRELSD", "HHORDRELSD", JdeDataType.String, 2),
        new JdeField("HHORDSLMET", "HHORDSLMET", JdeDataType.String, 2),
        new JdeField("HHSLMTRLCH", "HHSLMTRLCH", JdeDataType.String, 2),
        new JdeField("HHSLRCHAR1", "HHSLRCHAR1", JdeDataType.String, 2),
        new JdeField("HHSLRCHAR2", "HHSLRCHAR2", JdeDataType.String, 2),
        new JdeField("HHSLRCHAR3", "HHSLRCHAR3", JdeDataType.String, 2),
        new JdeField("HHSLRSTRG1", "HHSLRSTRG1", JdeDataType.String, 60),
        new JdeField("HHSLRSTRG2", "HHSLRSTRG2", JdeDataType.String, 60),
        new JdeField("HHSLRSTRG3", "HHSLRSTRG3", JdeDataType.String, 60),
        new JdeField("HHSLRAMNT1", "HHSLRAMNT1", JdeDataType.Numeric),
        new JdeField("HHSLRAMNT2", "HHSLRAMNT2", JdeDataType.Numeric),
        new JdeField("HHSLRAMNT3", "HHSLRAMNT3", JdeDataType.Numeric),
        new JdeField("HHSLRNUMB1", "HHSLRNUMB1", JdeDataType.Numeric),
        new JdeField("HHSLRNUMB2", "HHSLRNUMB2", JdeDataType.Numeric),
        new JdeField("HHSLRNUMB3", "HHSLRNUMB3", JdeDataType.Numeric),
        new JdeField("HHSLRDATE1", "HHSLRDATE1", JdeDataType.Numeric),
        new JdeField("HHSLRDATE2", "HHSLRDATE2", JdeDataType.Numeric),
        new JdeField("HHSLRDATE3", "HHSLRDATE3", JdeDataType.Numeric),
        new JdeField("HHSLRCODE1", "HHSLRCODE1", JdeDataType.String, 4),
        new JdeField("HHSLRCODE2", "HHSLRCODE2", JdeDataType.String, 4),
        new JdeField("HHSLRCODE3", "HHSLRCODE3", JdeDataType.String, 4),
        new JdeField("HHURCD", "HHURCD", JdeDataType.String, 4),
        new JdeField("HHURDT", "HHURDT", JdeDataType.Numeric),
        new JdeField("HHURAT", "HHURAT", JdeDataType.Numeric),
        new JdeField("HHURAB", "HHURAB", JdeDataType.Numeric),
        new JdeField("HHURRF", "HHURRF", JdeDataType.String, 30),
        new JdeField("HHUSER", "HHUSER", JdeDataType.String, 20),
        new JdeField("HHPID", "HHPID", JdeDataType.String, 20),
        new JdeField("HHJOBN", "HHJOBN", JdeDataType.String, 20),
        new JdeField("HHUPMJ", "HHUPMJ", JdeDataType.Numeric),
        new JdeField("HHTDAY", "HHTDAY", JdeDataType.Numeric),
        new JdeField("HHUTIME", "HHUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277709_0", "Primary Key on HHKCOO, HHDOCO, HHDCTO", new[] { "HHKCOO", "HHDOCO", "HHDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
