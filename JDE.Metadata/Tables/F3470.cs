using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3470 - .
/// </summary>
public class F3470 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSMCU.
        /// </summary>
        public const string DSMCU = "DSMCU";

        /// <summary>
        /// DSSHAN.
        /// </summary>
        public const string DSSHAN = "DSSHAN";

        /// <summary>
        /// DSITM.
        /// </summary>
        public const string DSITM = "DSITM";

        /// <summary>
        /// DSRU01.
        /// </summary>
        public const string DSRU01 = "DSRU01";

        /// <summary>
        /// DSRU02.
        /// </summary>
        public const string DSRU02 = "DSRU02";

        /// <summary>
        /// DSRU03.
        /// </summary>
        public const string DSRU03 = "DSRU03";

        /// <summary>
        /// DSRU04.
        /// </summary>
        public const string DSRU04 = "DSRU04";

        /// <summary>
        /// DSRU05.
        /// </summary>
        public const string DSRU05 = "DSRU05";

        /// <summary>
        /// DSRU06.
        /// </summary>
        public const string DSRU06 = "DSRU06";

        /// <summary>
        /// DSRU07.
        /// </summary>
        public const string DSRU07 = "DSRU07";

        /// <summary>
        /// DSRU08.
        /// </summary>
        public const string DSRU08 = "DSRU08";

        /// <summary>
        /// DSRU09.
        /// </summary>
        public const string DSRU09 = "DSRU09";

        /// <summary>
        /// DSRU10.
        /// </summary>
        public const string DSRU10 = "DSRU10";

        /// <summary>
        /// DSRU11.
        /// </summary>
        public const string DSRU11 = "DSRU11";

        /// <summary>
        /// DSRU12.
        /// </summary>
        public const string DSRU12 = "DSRU12";

        /// <summary>
        /// DSRU13.
        /// </summary>
        public const string DSRU13 = "DSRU13";

        /// <summary>
        /// DSRU14.
        /// </summary>
        public const string DSRU14 = "DSRU14";

        /// <summary>
        /// DSDTPN.
        /// </summary>
        public const string DSDTPN = "DSDTPN";

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSURCD.
        /// </summary>
        public const string DSURCD = "DSURCD";

        /// <summary>
        /// DSURDT.
        /// </summary>
        public const string DSURDT = "DSURDT";

        /// <summary>
        /// DSURAT.
        /// </summary>
        public const string DSURAT = "DSURAT";

        /// <summary>
        /// DSURAB.
        /// </summary>
        public const string DSURAB = "DSURAB";

        /// <summary>
        /// DSURRF.
        /// </summary>
        public const string DSURRF = "DSURRF";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSWRKSTNID.
        /// </summary>
        public const string DSWRKSTNID = "DSWRKSTNID";

        /// <summary>
        /// DSUPMJ.
        /// </summary>
        public const string DSUPMJ = "DSUPMJ";

        /// <summary>
        /// DSTDAY.
        /// </summary>
        public const string DSTDAY = "DSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3470";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSMCU", "DSMCU", JdeDataType.String, 24, true, true),
        new JdeField("DSSHAN", "DSSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("DSITM", "DSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("DSRU01", "DSRU01", JdeDataType.Numeric),
        new JdeField("DSRU02", "DSRU02", JdeDataType.Numeric),
        new JdeField("DSRU03", "DSRU03", JdeDataType.Numeric),
        new JdeField("DSRU04", "DSRU04", JdeDataType.Numeric),
        new JdeField("DSRU05", "DSRU05", JdeDataType.Numeric),
        new JdeField("DSRU06", "DSRU06", JdeDataType.Numeric),
        new JdeField("DSRU07", "DSRU07", JdeDataType.Numeric),
        new JdeField("DSRU08", "DSRU08", JdeDataType.Numeric),
        new JdeField("DSRU09", "DSRU09", JdeDataType.Numeric),
        new JdeField("DSRU10", "DSRU10", JdeDataType.Numeric),
        new JdeField("DSRU11", "DSRU11", JdeDataType.Numeric),
        new JdeField("DSRU12", "DSRU12", JdeDataType.Numeric),
        new JdeField("DSRU13", "DSRU13", JdeDataType.Numeric),
        new JdeField("DSRU14", "DSRU14", JdeDataType.Numeric),
        new JdeField("DSDTPN", "DSDTPN", JdeDataType.String, 2),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSURCD", "DSURCD", JdeDataType.String, 4),
        new JdeField("DSURDT", "DSURDT", JdeDataType.Numeric),
        new JdeField("DSURAT", "DSURAT", JdeDataType.Numeric),
        new JdeField("DSURAB", "DSURAB", JdeDataType.Numeric),
        new JdeField("DSURRF", "DSURRF", JdeDataType.String, 30),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSWRKSTNID", "DSWRKSTNID", JdeDataType.String, 20),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSTDAY", "DSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3470_0", "Primary Key on DSMCU, DSSHAN, DSITM", new[] { "DSMCU", "DSSHAN", "DSITM" }, isUnique: true, isPrimaryKey: true)
    };
}
