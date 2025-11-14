using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4091 - .
/// </summary>
public class F4091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KFKVER.
        /// </summary>
        public const string KFKVER = "KFKVER";

        /// <summary>
        /// KFKC01.
        /// </summary>
        public const string KFKC01 = "KFKC01";

        /// <summary>
        /// KFKC02.
        /// </summary>
        public const string KFKC02 = "KFKC02";

        /// <summary>
        /// KFKC03.
        /// </summary>
        public const string KFKC03 = "KFKC03";

        /// <summary>
        /// KFKC04.
        /// </summary>
        public const string KFKC04 = "KFKC04";

        /// <summary>
        /// KFKC05.
        /// </summary>
        public const string KFKC05 = "KFKC05";

        /// <summary>
        /// KFKC06.
        /// </summary>
        public const string KFKC06 = "KFKC06";

        /// <summary>
        /// KFKC07.
        /// </summary>
        public const string KFKC07 = "KFKC07";

        /// <summary>
        /// KFKC08.
        /// </summary>
        public const string KFKC08 = "KFKC08";

        /// <summary>
        /// KFKC09.
        /// </summary>
        public const string KFKC09 = "KFKC09";

        /// <summary>
        /// KFKC10.
        /// </summary>
        public const string KFKC10 = "KFKC10";

        /// <summary>
        /// KFKC11.
        /// </summary>
        public const string KFKC11 = "KFKC11";

        /// <summary>
        /// KFKC12.
        /// </summary>
        public const string KFKC12 = "KFKC12";

        /// <summary>
        /// KFKC13.
        /// </summary>
        public const string KFKC13 = "KFKC13";

        /// <summary>
        /// KFKC14.
        /// </summary>
        public const string KFKC14 = "KFKC14";

        /// <summary>
        /// KFKC15.
        /// </summary>
        public const string KFKC15 = "KFKC15";

        /// <summary>
        /// KFKC16.
        /// </summary>
        public const string KFKC16 = "KFKC16";

        /// <summary>
        /// KFKC17.
        /// </summary>
        public const string KFKC17 = "KFKC17";

        /// <summary>
        /// KFKC18.
        /// </summary>
        public const string KFKC18 = "KFKC18";

        /// <summary>
        /// KFKC19.
        /// </summary>
        public const string KFKC19 = "KFKC19";

        /// <summary>
        /// KFKC20.
        /// </summary>
        public const string KFKC20 = "KFKC20";

        /// <summary>
        /// KFKC21.
        /// </summary>
        public const string KFKC21 = "KFKC21";

        /// <summary>
        /// KFKC22.
        /// </summary>
        public const string KFKC22 = "KFKC22";

        /// <summary>
        /// KFKC23.
        /// </summary>
        public const string KFKC23 = "KFKC23";

        /// <summary>
        /// KFKC24.
        /// </summary>
        public const string KFKC24 = "KFKC24";

        /// <summary>
        /// KFKC25.
        /// </summary>
        public const string KFKC25 = "KFKC25";

        /// <summary>
        /// KFKC26.
        /// </summary>
        public const string KFKC26 = "KFKC26";

        /// <summary>
        /// KFKC27.
        /// </summary>
        public const string KFKC27 = "KFKC27";

        /// <summary>
        /// KFKC28.
        /// </summary>
        public const string KFKC28 = "KFKC28";

        /// <summary>
        /// KFKC29.
        /// </summary>
        public const string KFKC29 = "KFKC29";

        /// <summary>
        /// KFKC30.
        /// </summary>
        public const string KFKC30 = "KFKC30";

        /// <summary>
        /// KFKC31.
        /// </summary>
        public const string KFKC31 = "KFKC31";

        /// <summary>
        /// KFKC32.
        /// </summary>
        public const string KFKC32 = "KFKC32";

        /// <summary>
        /// KFKC33.
        /// </summary>
        public const string KFKC33 = "KFKC33";

        /// <summary>
        /// KFKC34.
        /// </summary>
        public const string KFKC34 = "KFKC34";

        /// <summary>
        /// KFKC35.
        /// </summary>
        public const string KFKC35 = "KFKC35";

        /// <summary>
        /// KFKC36.
        /// </summary>
        public const string KFKC36 = "KFKC36";

        /// <summary>
        /// KFKC37.
        /// </summary>
        public const string KFKC37 = "KFKC37";

        /// <summary>
        /// KFKC38.
        /// </summary>
        public const string KFKC38 = "KFKC38";

        /// <summary>
        /// KFKC39.
        /// </summary>
        public const string KFKC39 = "KFKC39";

        /// <summary>
        /// KFKC40.
        /// </summary>
        public const string KFKC40 = "KFKC40";

        /// <summary>
        /// KFGLSM.
        /// </summary>
        public const string KFGLSM = "KFGLSM";

        /// <summary>
        /// KFCOSM.
        /// </summary>
        public const string KFCOSM = "KFCOSM";

        /// <summary>
        /// KFITSM.
        /// </summary>
        public const string KFITSM = "KFITSM";

        /// <summary>
        /// KFCSLV.
        /// </summary>
        public const string KFCSLV = "KFCSLV";

        /// <summary>
        /// KFUPMJ.
        /// </summary>
        public const string KFUPMJ = "KFUPMJ";

        /// <summary>
        /// KFUSER.
        /// </summary>
        public const string KFUSER = "KFUSER";

        /// <summary>
        /// KFJOBN.
        /// </summary>
        public const string KFJOBN = "KFJOBN";

        /// <summary>
        /// KFPID.
        /// </summary>
        public const string KFPID = "KFPID";

        /// <summary>
        /// KFTDAY.
        /// </summary>
        public const string KFTDAY = "KFTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KFKVER", "KFKVER", JdeDataType.String, 6, true, true),
        new JdeField("KFKC01", "KFKC01", JdeDataType.Numeric),
        new JdeField("KFKC02", "KFKC02", JdeDataType.Numeric),
        new JdeField("KFKC03", "KFKC03", JdeDataType.Numeric),
        new JdeField("KFKC04", "KFKC04", JdeDataType.Numeric),
        new JdeField("KFKC05", "KFKC05", JdeDataType.Numeric),
        new JdeField("KFKC06", "KFKC06", JdeDataType.Numeric),
        new JdeField("KFKC07", "KFKC07", JdeDataType.Numeric),
        new JdeField("KFKC08", "KFKC08", JdeDataType.Numeric),
        new JdeField("KFKC09", "KFKC09", JdeDataType.Numeric),
        new JdeField("KFKC10", "KFKC10", JdeDataType.Numeric),
        new JdeField("KFKC11", "KFKC11", JdeDataType.Numeric),
        new JdeField("KFKC12", "KFKC12", JdeDataType.Numeric),
        new JdeField("KFKC13", "KFKC13", JdeDataType.Numeric),
        new JdeField("KFKC14", "KFKC14", JdeDataType.Numeric),
        new JdeField("KFKC15", "KFKC15", JdeDataType.Numeric),
        new JdeField("KFKC16", "KFKC16", JdeDataType.Numeric),
        new JdeField("KFKC17", "KFKC17", JdeDataType.Numeric),
        new JdeField("KFKC18", "KFKC18", JdeDataType.Numeric),
        new JdeField("KFKC19", "KFKC19", JdeDataType.Numeric),
        new JdeField("KFKC20", "KFKC20", JdeDataType.Numeric),
        new JdeField("KFKC21", "KFKC21", JdeDataType.Numeric),
        new JdeField("KFKC22", "KFKC22", JdeDataType.Numeric),
        new JdeField("KFKC23", "KFKC23", JdeDataType.Numeric),
        new JdeField("KFKC24", "KFKC24", JdeDataType.Numeric),
        new JdeField("KFKC25", "KFKC25", JdeDataType.Numeric),
        new JdeField("KFKC26", "KFKC26", JdeDataType.Numeric),
        new JdeField("KFKC27", "KFKC27", JdeDataType.Numeric),
        new JdeField("KFKC28", "KFKC28", JdeDataType.Numeric),
        new JdeField("KFKC29", "KFKC29", JdeDataType.Numeric),
        new JdeField("KFKC30", "KFKC30", JdeDataType.Numeric),
        new JdeField("KFKC31", "KFKC31", JdeDataType.Numeric),
        new JdeField("KFKC32", "KFKC32", JdeDataType.Numeric),
        new JdeField("KFKC33", "KFKC33", JdeDataType.Numeric),
        new JdeField("KFKC34", "KFKC34", JdeDataType.Numeric),
        new JdeField("KFKC35", "KFKC35", JdeDataType.Numeric),
        new JdeField("KFKC36", "KFKC36", JdeDataType.Numeric),
        new JdeField("KFKC37", "KFKC37", JdeDataType.Numeric),
        new JdeField("KFKC38", "KFKC38", JdeDataType.Numeric),
        new JdeField("KFKC39", "KFKC39", JdeDataType.Numeric),
        new JdeField("KFKC40", "KFKC40", JdeDataType.Numeric),
        new JdeField("KFGLSM", "KFGLSM", JdeDataType.String, 2),
        new JdeField("KFCOSM", "KFCOSM", JdeDataType.String, 2),
        new JdeField("KFITSM", "KFITSM", JdeDataType.String, 2),
        new JdeField("KFCSLV", "KFCSLV", JdeDataType.String, 4),
        new JdeField("KFUPMJ", "KFUPMJ", JdeDataType.Numeric),
        new JdeField("KFUSER", "KFUSER", JdeDataType.String, 20),
        new JdeField("KFJOBN", "KFJOBN", JdeDataType.String, 20),
        new JdeField("KFPID", "KFPID", JdeDataType.String, 20),
        new JdeField("KFTDAY", "KFTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4091_0", "Primary Key on KFKVER", new[] { "KFKVER" }, isUnique: true, isPrimaryKey: true)
    };
}
