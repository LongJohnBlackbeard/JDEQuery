using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B04A - .
/// </summary>
public class F76B04A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RFBRRCT.
        /// </summary>
        public const string RFBRRCT = "RFBRRCT";

        /// <summary>
        /// RFAN8.
        /// </summary>
        public const string RFAN8 = "RFAN8";

        /// <summary>
        /// RFAN01.
        /// </summary>
        public const string RFAN01 = "RFAN01";

        /// <summary>
        /// RFAN02.
        /// </summary>
        public const string RFAN02 = "RFAN02";

        /// <summary>
        /// RFAN03.
        /// </summary>
        public const string RFAN03 = "RFAN03";

        /// <summary>
        /// RFAN04.
        /// </summary>
        public const string RFAN04 = "RFAN04";

        /// <summary>
        /// RFAN05.
        /// </summary>
        public const string RFAN05 = "RFAN05";

        /// <summary>
        /// RFAN06.
        /// </summary>
        public const string RFAN06 = "RFAN06";

        /// <summary>
        /// RFAN07.
        /// </summary>
        public const string RFAN07 = "RFAN07";

        /// <summary>
        /// RFAN08.
        /// </summary>
        public const string RFAN08 = "RFAN08";

        /// <summary>
        /// RFAN09.
        /// </summary>
        public const string RFAN09 = "RFAN09";

        /// <summary>
        /// RFAN10.
        /// </summary>
        public const string RFAN10 = "RFAN10";

        /// <summary>
        /// RFAN11.
        /// </summary>
        public const string RFAN11 = "RFAN11";

        /// <summary>
        /// RFAN12.
        /// </summary>
        public const string RFAN12 = "RFAN12";

        /// <summary>
        /// RFAN13.
        /// </summary>
        public const string RFAN13 = "RFAN13";

        /// <summary>
        /// RFAN14.
        /// </summary>
        public const string RFAN14 = "RFAN14";

        /// <summary>
        /// RFAN15.
        /// </summary>
        public const string RFAN15 = "RFAN15";

        /// <summary>
        /// RFAN16.
        /// </summary>
        public const string RFAN16 = "RFAN16";

        /// <summary>
        /// RFAN17.
        /// </summary>
        public const string RFAN17 = "RFAN17";

        /// <summary>
        /// RFAN18.
        /// </summary>
        public const string RFAN18 = "RFAN18";

        /// <summary>
        /// RFAN19.
        /// </summary>
        public const string RFAN19 = "RFAN19";

        /// <summary>
        /// RFAN20.
        /// </summary>
        public const string RFAN20 = "RFAN20";

        /// <summary>
        /// RFAN21.
        /// </summary>
        public const string RFAN21 = "RFAN21";

        /// <summary>
        /// RFAN22.
        /// </summary>
        public const string RFAN22 = "RFAN22";

        /// <summary>
        /// RFAN23.
        /// </summary>
        public const string RFAN23 = "RFAN23";

        /// <summary>
        /// RFAN24.
        /// </summary>
        public const string RFAN24 = "RFAN24";

        /// <summary>
        /// RFAN25.
        /// </summary>
        public const string RFAN25 = "RFAN25";

        /// <summary>
        /// RFAN26.
        /// </summary>
        public const string RFAN26 = "RFAN26";

        /// <summary>
        /// RFAN27.
        /// </summary>
        public const string RFAN27 = "RFAN27";

        /// <summary>
        /// RFAN28.
        /// </summary>
        public const string RFAN28 = "RFAN28";

        /// <summary>
        /// RFAN29.
        /// </summary>
        public const string RFAN29 = "RFAN29";

        /// <summary>
        /// RFAN30.
        /// </summary>
        public const string RFAN30 = "RFAN30";

        /// <summary>
        /// RFAN31.
        /// </summary>
        public const string RFAN31 = "RFAN31";

        /// <summary>
        /// RFAN32.
        /// </summary>
        public const string RFAN32 = "RFAN32";

        /// <summary>
        /// RFAN33.
        /// </summary>
        public const string RFAN33 = "RFAN33";

        /// <summary>
        /// RFAN34.
        /// </summary>
        public const string RFAN34 = "RFAN34";

        /// <summary>
        /// RFAN35.
        /// </summary>
        public const string RFAN35 = "RFAN35";

        /// <summary>
        /// RFAN36.
        /// </summary>
        public const string RFAN36 = "RFAN36";
    }

    /// <inheritdoc />
    public override string TableName => "F76B04A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RFBRRCT", "RFBRRCT", JdeDataType.Numeric, null, true, true),
        new JdeField("RFAN8", "RFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RFAN01", "RFAN01", JdeDataType.Numeric),
        new JdeField("RFAN02", "RFAN02", JdeDataType.Numeric),
        new JdeField("RFAN03", "RFAN03", JdeDataType.Numeric),
        new JdeField("RFAN04", "RFAN04", JdeDataType.Numeric),
        new JdeField("RFAN05", "RFAN05", JdeDataType.Numeric),
        new JdeField("RFAN06", "RFAN06", JdeDataType.Numeric),
        new JdeField("RFAN07", "RFAN07", JdeDataType.Numeric),
        new JdeField("RFAN08", "RFAN08", JdeDataType.Numeric),
        new JdeField("RFAN09", "RFAN09", JdeDataType.Numeric),
        new JdeField("RFAN10", "RFAN10", JdeDataType.Numeric),
        new JdeField("RFAN11", "RFAN11", JdeDataType.Numeric),
        new JdeField("RFAN12", "RFAN12", JdeDataType.Numeric),
        new JdeField("RFAN13", "RFAN13", JdeDataType.Numeric),
        new JdeField("RFAN14", "RFAN14", JdeDataType.Numeric),
        new JdeField("RFAN15", "RFAN15", JdeDataType.Numeric),
        new JdeField("RFAN16", "RFAN16", JdeDataType.Numeric),
        new JdeField("RFAN17", "RFAN17", JdeDataType.Numeric),
        new JdeField("RFAN18", "RFAN18", JdeDataType.Numeric),
        new JdeField("RFAN19", "RFAN19", JdeDataType.Numeric),
        new JdeField("RFAN20", "RFAN20", JdeDataType.Numeric),
        new JdeField("RFAN21", "RFAN21", JdeDataType.Numeric),
        new JdeField("RFAN22", "RFAN22", JdeDataType.Numeric),
        new JdeField("RFAN23", "RFAN23", JdeDataType.Numeric),
        new JdeField("RFAN24", "RFAN24", JdeDataType.Numeric),
        new JdeField("RFAN25", "RFAN25", JdeDataType.Numeric),
        new JdeField("RFAN26", "RFAN26", JdeDataType.Numeric),
        new JdeField("RFAN27", "RFAN27", JdeDataType.Numeric),
        new JdeField("RFAN28", "RFAN28", JdeDataType.Numeric),
        new JdeField("RFAN29", "RFAN29", JdeDataType.Numeric),
        new JdeField("RFAN30", "RFAN30", JdeDataType.Numeric),
        new JdeField("RFAN31", "RFAN31", JdeDataType.Numeric),
        new JdeField("RFAN32", "RFAN32", JdeDataType.Numeric),
        new JdeField("RFAN33", "RFAN33", JdeDataType.Numeric),
        new JdeField("RFAN34", "RFAN34", JdeDataType.Numeric),
        new JdeField("RFAN35", "RFAN35", JdeDataType.Numeric),
        new JdeField("RFAN36", "RFAN36", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B04A_0", "Primary Key on RFBRRCT, RFAN8", new[] { "RFBRRCT", "RFAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
