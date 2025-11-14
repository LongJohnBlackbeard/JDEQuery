using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0701733 - .
/// </summary>
public class F0701733 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YCAN8.
        /// </summary>
        public const string YCAN8 = "YCAN8";

        /// <summary>
        /// YCNONRA.
        /// </summary>
        public const string YCNONRA = "YCNONRA";

        /// <summary>
        /// YCFDEXMPT.
        /// </summary>
        public const string YCFDEXMPT = "YCFDEXMPT";

        /// <summary>
        /// YCSTEXMPT.
        /// </summary>
        public const string YCSTEXMPT = "YCSTEXMPT";

        /// <summary>
        /// YCFICEXMPT.
        /// </summary>
        public const string YCFICEXMPT = "YCFICEXMPT";

        /// <summary>
        /// YCMEDEXMPT.
        /// </summary>
        public const string YCMEDEXMPT = "YCMEDEXMPT";

        /// <summary>
        /// YCPRICO.
        /// </summary>
        public const string YCPRICO = "YCPRICO";

        /// <summary>
        /// YCCDNRES.
        /// </summary>
        public const string YCCDNRES = "YCCDNRES";

        /// <summary>
        /// YCSTATEE.
        /// </summary>
        public const string YCSTATEE = "YCSTATEE";

        /// <summary>
        /// YCSPCLTX.
        /// </summary>
        public const string YCSPCLTX = "YCSPCLTX";

        /// <summary>
        /// YCCNTEMP.
        /// </summary>
        public const string YCCNTEMP = "YCCNTEMP";

        /// <summary>
        /// YCEIEXMPT.
        /// </summary>
        public const string YCEIEXMPT = "YCEIEXMPT";

        /// <summary>
        /// YCPPEXMPT.
        /// </summary>
        public const string YCPPEXMPT = "YCPPEXMPT";

        /// <summary>
        /// YCPIPEXMPT.
        /// </summary>
        public const string YCPIPEXMPT = "YCPIPEXMPT";

        /// <summary>
        /// YCTAXM01.
        /// </summary>
        public const string YCTAXM01 = "YCTAXM01";

        /// <summary>
        /// YCTAXM02.
        /// </summary>
        public const string YCTAXM02 = "YCTAXM02";

        /// <summary>
        /// YCTAXM03.
        /// </summary>
        public const string YCTAXM03 = "YCTAXM03";

        /// <summary>
        /// YCTAXM04.
        /// </summary>
        public const string YCTAXM04 = "YCTAXM04";

        /// <summary>
        /// YCTAXM05.
        /// </summary>
        public const string YCTAXM05 = "YCTAXM05";

        /// <summary>
        /// YCTAXM06.
        /// </summary>
        public const string YCTAXM06 = "YCTAXM06";

        /// <summary>
        /// YCTAXM07.
        /// </summary>
        public const string YCTAXM07 = "YCTAXM07";

        /// <summary>
        /// YCTAXM08.
        /// </summary>
        public const string YCTAXM08 = "YCTAXM08";

        /// <summary>
        /// YCTAXM09.
        /// </summary>
        public const string YCTAXM09 = "YCTAXM09";

        /// <summary>
        /// YCTAXM10.
        /// </summary>
        public const string YCTAXM10 = "YCTAXM10";

        /// <summary>
        /// YCUPMJ.
        /// </summary>
        public const string YCUPMJ = "YCUPMJ";

        /// <summary>
        /// YCUPMT.
        /// </summary>
        public const string YCUPMT = "YCUPMT";

        /// <summary>
        /// YCUSER.
        /// </summary>
        public const string YCUSER = "YCUSER";

        /// <summary>
        /// YCJOBN.
        /// </summary>
        public const string YCJOBN = "YCJOBN";

        /// <summary>
        /// YCPID.
        /// </summary>
        public const string YCPID = "YCPID";
    }

    /// <inheritdoc />
    public override string TableName => "F0701733";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YCAN8", "YCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YCNONRA", "YCNONRA", JdeDataType.String, 2),
        new JdeField("YCFDEXMPT", "YCFDEXMPT", JdeDataType.String, 2),
        new JdeField("YCSTEXMPT", "YCSTEXMPT", JdeDataType.String, 2),
        new JdeField("YCFICEXMPT", "YCFICEXMPT", JdeDataType.String, 2),
        new JdeField("YCMEDEXMPT", "YCMEDEXMPT", JdeDataType.String, 2),
        new JdeField("YCPRICO", "YCPRICO", JdeDataType.String, 2),
        new JdeField("YCCDNRES", "YCCDNRES", JdeDataType.String, 2),
        new JdeField("YCSTATEE", "YCSTATEE", JdeDataType.String, 2),
        new JdeField("YCSPCLTX", "YCSPCLTX", JdeDataType.String, 2),
        new JdeField("YCCNTEMP", "YCCNTEMP", JdeDataType.String, 2),
        new JdeField("YCEIEXMPT", "YCEIEXMPT", JdeDataType.String, 2),
        new JdeField("YCPPEXMPT", "YCPPEXMPT", JdeDataType.String, 2),
        new JdeField("YCPIPEXMPT", "YCPIPEXMPT", JdeDataType.String, 2),
        new JdeField("YCTAXM01", "YCTAXM01", JdeDataType.String, 2),
        new JdeField("YCTAXM02", "YCTAXM02", JdeDataType.String, 2),
        new JdeField("YCTAXM03", "YCTAXM03", JdeDataType.String, 2),
        new JdeField("YCTAXM04", "YCTAXM04", JdeDataType.String, 2),
        new JdeField("YCTAXM05", "YCTAXM05", JdeDataType.String, 2),
        new JdeField("YCTAXM06", "YCTAXM06", JdeDataType.String, 2),
        new JdeField("YCTAXM07", "YCTAXM07", JdeDataType.String, 2),
        new JdeField("YCTAXM08", "YCTAXM08", JdeDataType.String, 2),
        new JdeField("YCTAXM09", "YCTAXM09", JdeDataType.String, 2),
        new JdeField("YCTAXM10", "YCTAXM10", JdeDataType.String, 2),
        new JdeField("YCUPMJ", "YCUPMJ", JdeDataType.Numeric),
        new JdeField("YCUPMT", "YCUPMT", JdeDataType.Numeric),
        new JdeField("YCUSER", "YCUSER", JdeDataType.String, 20),
        new JdeField("YCJOBN", "YCJOBN", JdeDataType.String, 20),
        new JdeField("YCPID", "YCPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0701733_0", "Primary Key on YCAN8", new[] { "YCAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
