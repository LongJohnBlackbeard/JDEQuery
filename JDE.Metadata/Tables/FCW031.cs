using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW031 - .
/// </summary>
public class FCW031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPC9GRCD.
        /// </summary>
        public const string SPC9GRCD = "SPC9GRCD";

        /// <summary>
        /// SPC9SRPX.
        /// </summary>
        public const string SPC9SRPX = "SPC9SRPX";

        /// <summary>
        /// SPC9AC.
        /// </summary>
        public const string SPC9AC = "SPC9AC";

        /// <summary>
        /// SPC9RPC01.
        /// </summary>
        public const string SPC9RPC01 = "SPC9RPC01";

        /// <summary>
        /// SPC9RPC02.
        /// </summary>
        public const string SPC9RPC02 = "SPC9RPC02";

        /// <summary>
        /// SPC9RPC03.
        /// </summary>
        public const string SPC9RPC03 = "SPC9RPC03";

        /// <summary>
        /// SPC9RPC04.
        /// </summary>
        public const string SPC9RPC04 = "SPC9RPC04";

        /// <summary>
        /// SPC9RPC05.
        /// </summary>
        public const string SPC9RPC05 = "SPC9RPC05";

        /// <summary>
        /// SPC9RPC06.
        /// </summary>
        public const string SPC9RPC06 = "SPC9RPC06";

        /// <summary>
        /// SPC9RPC07.
        /// </summary>
        public const string SPC9RPC07 = "SPC9RPC07";

        /// <summary>
        /// SPC9RPC08.
        /// </summary>
        public const string SPC9RPC08 = "SPC9RPC08";

        /// <summary>
        /// SPC9RPC09.
        /// </summary>
        public const string SPC9RPC09 = "SPC9RPC09";

        /// <summary>
        /// SPC9RPC10.
        /// </summary>
        public const string SPC9RPC10 = "SPC9RPC10";

        /// <summary>
        /// SPC9RPC11.
        /// </summary>
        public const string SPC9RPC11 = "SPC9RPC11";

        /// <summary>
        /// SPC9RPC12.
        /// </summary>
        public const string SPC9RPC12 = "SPC9RPC12";

        /// <summary>
        /// SPC9RPC13.
        /// </summary>
        public const string SPC9RPC13 = "SPC9RPC13";

        /// <summary>
        /// SPC9RPC14.
        /// </summary>
        public const string SPC9RPC14 = "SPC9RPC14";

        /// <summary>
        /// SPC9RPC15.
        /// </summary>
        public const string SPC9RPC15 = "SPC9RPC15";

        /// <summary>
        /// SPC9RPC16.
        /// </summary>
        public const string SPC9RPC16 = "SPC9RPC16";

        /// <summary>
        /// SPC9RPC17.
        /// </summary>
        public const string SPC9RPC17 = "SPC9RPC17";

        /// <summary>
        /// SPC9RPC18.
        /// </summary>
        public const string SPC9RPC18 = "SPC9RPC18";

        /// <summary>
        /// SPC9RPC19.
        /// </summary>
        public const string SPC9RPC19 = "SPC9RPC19";

        /// <summary>
        /// SPC9RPC20.
        /// </summary>
        public const string SPC9RPC20 = "SPC9RPC20";

        /// <summary>
        /// SPC9RPC21.
        /// </summary>
        public const string SPC9RPC21 = "SPC9RPC21";

        /// <summary>
        /// SPC9RPC22.
        /// </summary>
        public const string SPC9RPC22 = "SPC9RPC22";

        /// <summary>
        /// SPC9RPC23.
        /// </summary>
        public const string SPC9RPC23 = "SPC9RPC23";

        /// <summary>
        /// SPC9RPC24.
        /// </summary>
        public const string SPC9RPC24 = "SPC9RPC24";

        /// <summary>
        /// SPC9RPC25.
        /// </summary>
        public const string SPC9RPC25 = "SPC9RPC25";

        /// <summary>
        /// SPC9RPC26.
        /// </summary>
        public const string SPC9RPC26 = "SPC9RPC26";

        /// <summary>
        /// SPC9RPC27.
        /// </summary>
        public const string SPC9RPC27 = "SPC9RPC27";

        /// <summary>
        /// SPC9RPC28.
        /// </summary>
        public const string SPC9RPC28 = "SPC9RPC28";

        /// <summary>
        /// SPC9RPC29.
        /// </summary>
        public const string SPC9RPC29 = "SPC9RPC29";

        /// <summary>
        /// SPC9RPC30.
        /// </summary>
        public const string SPC9RPC30 = "SPC9RPC30";
    }

    /// <inheritdoc />
    public override string TableName => "FCW031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPC9GRCD", "SPC9GRCD", JdeDataType.String, 6, true, true),
        new JdeField("SPC9SRPX", "SPC9SRPX", JdeDataType.String, 12, true, true),
        new JdeField("SPC9AC", "SPC9AC", JdeDataType.String, 6, true, true),
        new JdeField("SPC9RPC01", "SPC9RPC01", JdeDataType.Numeric),
        new JdeField("SPC9RPC02", "SPC9RPC02", JdeDataType.Numeric),
        new JdeField("SPC9RPC03", "SPC9RPC03", JdeDataType.Numeric),
        new JdeField("SPC9RPC04", "SPC9RPC04", JdeDataType.Numeric),
        new JdeField("SPC9RPC05", "SPC9RPC05", JdeDataType.Numeric),
        new JdeField("SPC9RPC06", "SPC9RPC06", JdeDataType.Numeric),
        new JdeField("SPC9RPC07", "SPC9RPC07", JdeDataType.Numeric),
        new JdeField("SPC9RPC08", "SPC9RPC08", JdeDataType.Numeric),
        new JdeField("SPC9RPC09", "SPC9RPC09", JdeDataType.Numeric),
        new JdeField("SPC9RPC10", "SPC9RPC10", JdeDataType.Numeric),
        new JdeField("SPC9RPC11", "SPC9RPC11", JdeDataType.Numeric),
        new JdeField("SPC9RPC12", "SPC9RPC12", JdeDataType.Numeric),
        new JdeField("SPC9RPC13", "SPC9RPC13", JdeDataType.Numeric),
        new JdeField("SPC9RPC14", "SPC9RPC14", JdeDataType.Numeric),
        new JdeField("SPC9RPC15", "SPC9RPC15", JdeDataType.Numeric),
        new JdeField("SPC9RPC16", "SPC9RPC16", JdeDataType.Numeric),
        new JdeField("SPC9RPC17", "SPC9RPC17", JdeDataType.Numeric),
        new JdeField("SPC9RPC18", "SPC9RPC18", JdeDataType.Numeric),
        new JdeField("SPC9RPC19", "SPC9RPC19", JdeDataType.Numeric),
        new JdeField("SPC9RPC20", "SPC9RPC20", JdeDataType.Numeric),
        new JdeField("SPC9RPC21", "SPC9RPC21", JdeDataType.Numeric),
        new JdeField("SPC9RPC22", "SPC9RPC22", JdeDataType.Numeric),
        new JdeField("SPC9RPC23", "SPC9RPC23", JdeDataType.Numeric),
        new JdeField("SPC9RPC24", "SPC9RPC24", JdeDataType.Numeric),
        new JdeField("SPC9RPC25", "SPC9RPC25", JdeDataType.Numeric),
        new JdeField("SPC9RPC26", "SPC9RPC26", JdeDataType.Numeric),
        new JdeField("SPC9RPC27", "SPC9RPC27", JdeDataType.Numeric),
        new JdeField("SPC9RPC28", "SPC9RPC28", JdeDataType.Numeric),
        new JdeField("SPC9RPC29", "SPC9RPC29", JdeDataType.Numeric),
        new JdeField("SPC9RPC30", "SPC9RPC30", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW031_0", "Primary Key on SPC9GRCD, SPC9SRPX, SPC9AC", new[] { "SPC9GRCD", "SPC9SRPX", "SPC9AC" }, isUnique: true, isPrimaryKey: true)
    };
}
