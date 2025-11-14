using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI74 - .
/// </summary>
public class F75IUI74 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICI75INVNO.
        /// </summary>
        public const string ICI75INVNO = "ICI75INVNO";

        /// <summary>
        /// ICYINVDT.
        /// </summary>
        public const string ICYINVDT = "ICYINVDT";

        /// <summary>
        /// ICDOC.
        /// </summary>
        public const string ICDOC = "ICDOC";

        /// <summary>
        /// ICDCT.
        /// </summary>
        public const string ICDCT = "ICDCT";

        /// <summary>
        /// ICKCO.
        /// </summary>
        public const string ICKCO = "ICKCO";

        /// <summary>
        /// ICI75GSTNO.
        /// </summary>
        public const string ICI75GSTNO = "ICI75GSTNO";

        /// <summary>
        /// ICI75INVVL.
        /// </summary>
        public const string ICI75INVVL = "ICI75INVVL";

        /// <summary>
        /// ICI75AIGST.
        /// </summary>
        public const string ICI75AIGST = "ICI75AIGST";

        /// <summary>
        /// ICI75ACGST.
        /// </summary>
        public const string ICI75ACGST = "ICI75ACGST";

        /// <summary>
        /// ICI75ASGST.
        /// </summary>
        public const string ICI75ASGST = "ICI75ASGST";

        /// <summary>
        /// ICI75ACESS.
        /// </summary>
        public const string ICI75ACESS = "ICI75ACESS";

        /// <summary>
        /// ICI75ITCAF.
        /// </summary>
        public const string ICI75ITCAF = "ICI75ITCAF";

        /// <summary>
        /// ICI75MCHFD.
        /// </summary>
        public const string ICI75MCHFD = "ICI75MCHFD";

        /// <summary>
        /// ICI75EIGST.
        /// </summary>
        public const string ICI75EIGST = "ICI75EIGST";

        /// <summary>
        /// ICI75ECGST.
        /// </summary>
        public const string ICI75ECGST = "ICI75ECGST";

        /// <summary>
        /// ICI75ESGST.
        /// </summary>
        public const string ICI75ESGST = "ICI75ESGST";

        /// <summary>
        /// ICI75ECESS.
        /// </summary>
        public const string ICI75ECESS = "ICI75ECESS";

        /// <summary>
        /// ICI75LIGST.
        /// </summary>
        public const string ICI75LIGST = "ICI75LIGST";

        /// <summary>
        /// ICI75LCGST.
        /// </summary>
        public const string ICI75LCGST = "ICI75LCGST";

        /// <summary>
        /// ICI75LSGST.
        /// </summary>
        public const string ICI75LSGST = "ICI75LSGST";

        /// <summary>
        /// ICI75LCESS.
        /// </summary>
        public const string ICI75LCESS = "ICI75LCESS";

        /// <summary>
        /// ICJOBS.
        /// </summary>
        public const string ICJOBS = "ICJOBS";

        /// <summary>
        /// ICUSER.
        /// </summary>
        public const string ICUSER = "ICUSER";

        /// <summary>
        /// ICPID.
        /// </summary>
        public const string ICPID = "ICPID";

        /// <summary>
        /// ICJOBN.
        /// </summary>
        public const string ICJOBN = "ICJOBN";

        /// <summary>
        /// ICUPMJ.
        /// </summary>
        public const string ICUPMJ = "ICUPMJ";

        /// <summary>
        /// ICUPMT.
        /// </summary>
        public const string ICUPMT = "ICUPMT";

        /// <summary>
        /// ICYFUTDT.
        /// </summary>
        public const string ICYFUTDT = "ICYFUTDT";

        /// <summary>
        /// ICFFU4.
        /// </summary>
        public const string ICFFU4 = "ICFFU4";

        /// <summary>
        /// ICFUT3.
        /// </summary>
        public const string ICFUT3 = "ICFUT3";

        /// <summary>
        /// ICX2.
        /// </summary>
        public const string ICX2 = "ICX2";

        /// <summary>
        /// ICFUTCH1.
        /// </summary>
        public const string ICFUTCH1 = "ICFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI74";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICI75INVNO", "ICI75INVNO", JdeDataType.String, 50, true, true),
        new JdeField("ICYINVDT", "ICYINVDT", JdeDataType.Numeric, null, true, true),
        new JdeField("ICDOC", "ICDOC", JdeDataType.Numeric),
        new JdeField("ICDCT", "ICDCT", JdeDataType.String, 4),
        new JdeField("ICKCO", "ICKCO", JdeDataType.String, 10),
        new JdeField("ICI75GSTNO", "ICI75GSTNO", JdeDataType.String, 50),
        new JdeField("ICI75INVVL", "ICI75INVVL", JdeDataType.Numeric),
        new JdeField("ICI75AIGST", "ICI75AIGST", JdeDataType.Numeric),
        new JdeField("ICI75ACGST", "ICI75ACGST", JdeDataType.Numeric),
        new JdeField("ICI75ASGST", "ICI75ASGST", JdeDataType.Numeric),
        new JdeField("ICI75ACESS", "ICI75ACESS", JdeDataType.Numeric),
        new JdeField("ICI75ITCAF", "ICI75ITCAF", JdeDataType.String, 2),
        new JdeField("ICI75MCHFD", "ICI75MCHFD", JdeDataType.String, 2),
        new JdeField("ICI75EIGST", "ICI75EIGST", JdeDataType.Numeric),
        new JdeField("ICI75ECGST", "ICI75ECGST", JdeDataType.Numeric),
        new JdeField("ICI75ESGST", "ICI75ESGST", JdeDataType.Numeric),
        new JdeField("ICI75ECESS", "ICI75ECESS", JdeDataType.Numeric),
        new JdeField("ICI75LIGST", "ICI75LIGST", JdeDataType.Numeric),
        new JdeField("ICI75LCGST", "ICI75LCGST", JdeDataType.Numeric),
        new JdeField("ICI75LSGST", "ICI75LSGST", JdeDataType.Numeric),
        new JdeField("ICI75LCESS", "ICI75LCESS", JdeDataType.Numeric),
        new JdeField("ICJOBS", "ICJOBS", JdeDataType.Numeric),
        new JdeField("ICUSER", "ICUSER", JdeDataType.String, 20),
        new JdeField("ICPID", "ICPID", JdeDataType.String, 20),
        new JdeField("ICJOBN", "ICJOBN", JdeDataType.String, 20),
        new JdeField("ICUPMJ", "ICUPMJ", JdeDataType.Numeric),
        new JdeField("ICUPMT", "ICUPMT", JdeDataType.Numeric),
        new JdeField("ICYFUTDT", "ICYFUTDT", JdeDataType.Numeric),
        new JdeField("ICFFU4", "ICFFU4", JdeDataType.Numeric),
        new JdeField("ICFUT3", "ICFUT3", JdeDataType.String, 60),
        new JdeField("ICX2", "ICX2", JdeDataType.String, 2),
        new JdeField("ICFUTCH1", "ICFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI74_0", "Primary Key on ICI75INVNO, ICYINVDT", new[] { "ICI75INVNO", "ICYINVDT" }, isUnique: true, isPrimaryKey: true)
    };
}
