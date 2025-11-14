using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277701 - .
/// </summary>
public class F4277701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHKCOO.
        /// </summary>
        public const string RHKCOO = "RHKCOO";

        /// <summary>
        /// RHDOCO.
        /// </summary>
        public const string RHDOCO = "RHDOCO";

        /// <summary>
        /// RHDCTO.
        /// </summary>
        public const string RHDCTO = "RHDCTO";

        /// <summary>
        /// RHORMNFLPR.
        /// </summary>
        public const string RHORMNFLPR = "RHORMNFLPR";

        /// <summary>
        /// RHSLOVRCD.
        /// </summary>
        public const string RHSLOVRCD = "RHSLOVRCD";

        /// <summary>
        /// RHOMFPLNID.
        /// </summary>
        public const string RHOMFPLNID = "RHOMFPLNID";

        /// <summary>
        /// RHSLCUSTFN.
        /// </summary>
        public const string RHSLCUSTFN = "RHSLCUSTFN";

        /// <summary>
        /// RHSLCFLNID.
        /// </summary>
        public const string RHSLCFLNID = "RHSLCFLNID";

        /// <summary>
        /// RHORDRELSD.
        /// </summary>
        public const string RHORDRELSD = "RHORDRELSD";

        /// <summary>
        /// RHORDSLMET.
        /// </summary>
        public const string RHORDSLMET = "RHORDSLMET";

        /// <summary>
        /// RHSLMTRLCH.
        /// </summary>
        public const string RHSLMTRLCH = "RHSLMTRLCH";

        /// <summary>
        /// RHSLRCHAR1.
        /// </summary>
        public const string RHSLRCHAR1 = "RHSLRCHAR1";

        /// <summary>
        /// RHSLRCHAR2.
        /// </summary>
        public const string RHSLRCHAR2 = "RHSLRCHAR2";

        /// <summary>
        /// RHSLRCHAR3.
        /// </summary>
        public const string RHSLRCHAR3 = "RHSLRCHAR3";

        /// <summary>
        /// RHSLRSTRG1.
        /// </summary>
        public const string RHSLRSTRG1 = "RHSLRSTRG1";

        /// <summary>
        /// RHSLRSTRG2.
        /// </summary>
        public const string RHSLRSTRG2 = "RHSLRSTRG2";

        /// <summary>
        /// RHSLRSTRG3.
        /// </summary>
        public const string RHSLRSTRG3 = "RHSLRSTRG3";

        /// <summary>
        /// RHSLRAMNT1.
        /// </summary>
        public const string RHSLRAMNT1 = "RHSLRAMNT1";

        /// <summary>
        /// RHSLRAMNT2.
        /// </summary>
        public const string RHSLRAMNT2 = "RHSLRAMNT2";

        /// <summary>
        /// RHSLRAMNT3.
        /// </summary>
        public const string RHSLRAMNT3 = "RHSLRAMNT3";

        /// <summary>
        /// RHSLRNUMB1.
        /// </summary>
        public const string RHSLRNUMB1 = "RHSLRNUMB1";

        /// <summary>
        /// RHSLRNUMB2.
        /// </summary>
        public const string RHSLRNUMB2 = "RHSLRNUMB2";

        /// <summary>
        /// RHSLRNUMB3.
        /// </summary>
        public const string RHSLRNUMB3 = "RHSLRNUMB3";

        /// <summary>
        /// RHSLRDATE1.
        /// </summary>
        public const string RHSLRDATE1 = "RHSLRDATE1";

        /// <summary>
        /// RHSLRDATE2.
        /// </summary>
        public const string RHSLRDATE2 = "RHSLRDATE2";

        /// <summary>
        /// RHSLRDATE3.
        /// </summary>
        public const string RHSLRDATE3 = "RHSLRDATE3";

        /// <summary>
        /// RHSLRCODE1.
        /// </summary>
        public const string RHSLRCODE1 = "RHSLRCODE1";

        /// <summary>
        /// RHSLRCODE2.
        /// </summary>
        public const string RHSLRCODE2 = "RHSLRCODE2";

        /// <summary>
        /// RHSLRCODE3.
        /// </summary>
        public const string RHSLRCODE3 = "RHSLRCODE3";

        /// <summary>
        /// RHURCD.
        /// </summary>
        public const string RHURCD = "RHURCD";

        /// <summary>
        /// RHURDT.
        /// </summary>
        public const string RHURDT = "RHURDT";

        /// <summary>
        /// RHURAT.
        /// </summary>
        public const string RHURAT = "RHURAT";

        /// <summary>
        /// RHURAB.
        /// </summary>
        public const string RHURAB = "RHURAB";

        /// <summary>
        /// RHURRF.
        /// </summary>
        public const string RHURRF = "RHURRF";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHTDAY.
        /// </summary>
        public const string RHTDAY = "RHTDAY";

        /// <summary>
        /// RHUTIME.
        /// </summary>
        public const string RHUTIME = "RHUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4277701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHKCOO", "RHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RHDOCO", "RHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RHDCTO", "RHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RHORMNFLPR", "RHORMNFLPR", JdeDataType.Numeric),
        new JdeField("RHSLOVRCD", "RHSLOVRCD", JdeDataType.String, 6),
        new JdeField("RHOMFPLNID", "RHOMFPLNID", JdeDataType.Numeric),
        new JdeField("RHSLCUSTFN", "RHSLCUSTFN", JdeDataType.String, 64),
        new JdeField("RHSLCFLNID", "RHSLCFLNID", JdeDataType.Numeric),
        new JdeField("RHORDRELSD", "RHORDRELSD", JdeDataType.String, 2),
        new JdeField("RHORDSLMET", "RHORDSLMET", JdeDataType.String, 2),
        new JdeField("RHSLMTRLCH", "RHSLMTRLCH", JdeDataType.String, 2),
        new JdeField("RHSLRCHAR1", "RHSLRCHAR1", JdeDataType.String, 2),
        new JdeField("RHSLRCHAR2", "RHSLRCHAR2", JdeDataType.String, 2),
        new JdeField("RHSLRCHAR3", "RHSLRCHAR3", JdeDataType.String, 2),
        new JdeField("RHSLRSTRG1", "RHSLRSTRG1", JdeDataType.String, 60),
        new JdeField("RHSLRSTRG2", "RHSLRSTRG2", JdeDataType.String, 60),
        new JdeField("RHSLRSTRG3", "RHSLRSTRG3", JdeDataType.String, 60),
        new JdeField("RHSLRAMNT1", "RHSLRAMNT1", JdeDataType.Numeric),
        new JdeField("RHSLRAMNT2", "RHSLRAMNT2", JdeDataType.Numeric),
        new JdeField("RHSLRAMNT3", "RHSLRAMNT3", JdeDataType.Numeric),
        new JdeField("RHSLRNUMB1", "RHSLRNUMB1", JdeDataType.Numeric),
        new JdeField("RHSLRNUMB2", "RHSLRNUMB2", JdeDataType.Numeric),
        new JdeField("RHSLRNUMB3", "RHSLRNUMB3", JdeDataType.Numeric),
        new JdeField("RHSLRDATE1", "RHSLRDATE1", JdeDataType.Numeric),
        new JdeField("RHSLRDATE2", "RHSLRDATE2", JdeDataType.Numeric),
        new JdeField("RHSLRDATE3", "RHSLRDATE3", JdeDataType.Numeric),
        new JdeField("RHSLRCODE1", "RHSLRCODE1", JdeDataType.String, 4),
        new JdeField("RHSLRCODE2", "RHSLRCODE2", JdeDataType.String, 4),
        new JdeField("RHSLRCODE3", "RHSLRCODE3", JdeDataType.String, 4),
        new JdeField("RHURCD", "RHURCD", JdeDataType.String, 4),
        new JdeField("RHURDT", "RHURDT", JdeDataType.Numeric),
        new JdeField("RHURAT", "RHURAT", JdeDataType.Numeric),
        new JdeField("RHURAB", "RHURAB", JdeDataType.Numeric),
        new JdeField("RHURRF", "RHURRF", JdeDataType.String, 30),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHTDAY", "RHTDAY", JdeDataType.Numeric),
        new JdeField("RHUTIME", "RHUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277701_0", "Primary Key on RHKCOO, RHDOCO, RHDCTO", new[] { "RHKCOO", "RHDOCO", "RHDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
