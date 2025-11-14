using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0150 - .
/// </summary>
public class F0150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MAOSTP.
        /// </summary>
        public const string MAOSTP = "MAOSTP";

        /// <summary>
        /// MAPA8.
        /// </summary>
        public const string MAPA8 = "MAPA8";

        /// <summary>
        /// MAAN8.
        /// </summary>
        public const string MAAN8 = "MAAN8";

        /// <summary>
        /// MADSS7.
        /// </summary>
        public const string MADSS7 = "MADSS7";

        /// <summary>
        /// MABEFD.
        /// </summary>
        public const string MABEFD = "MABEFD";

        /// <summary>
        /// MAEEFD.
        /// </summary>
        public const string MAEEFD = "MAEEFD";

        /// <summary>
        /// MARMK.
        /// </summary>
        public const string MARMK = "MARMK";

        /// <summary>
        /// MAUSER.
        /// </summary>
        public const string MAUSER = "MAUSER";

        /// <summary>
        /// MAUPMJ.
        /// </summary>
        public const string MAUPMJ = "MAUPMJ";

        /// <summary>
        /// MAPID.
        /// </summary>
        public const string MAPID = "MAPID";

        /// <summary>
        /// MAJOBN.
        /// </summary>
        public const string MAJOBN = "MAJOBN";

        /// <summary>
        /// MAUPMT.
        /// </summary>
        public const string MAUPMT = "MAUPMT";

        /// <summary>
        /// MASYNCS.
        /// </summary>
        public const string MASYNCS = "MASYNCS";
    }

    /// <inheritdoc />
    public override string TableName => "F0150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MAOSTP", "MAOSTP", JdeDataType.String, 6, true, true),
        new JdeField("MAPA8", "MAPA8", JdeDataType.Numeric, null, true, true),
        new JdeField("MAAN8", "MAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MADSS7", "MADSS7", JdeDataType.Numeric),
        new JdeField("MABEFD", "MABEFD", JdeDataType.Numeric),
        new JdeField("MAEEFD", "MAEEFD", JdeDataType.Numeric),
        new JdeField("MARMK", "MARMK", JdeDataType.String, 60),
        new JdeField("MAUSER", "MAUSER", JdeDataType.String, 20),
        new JdeField("MAUPMJ", "MAUPMJ", JdeDataType.Numeric),
        new JdeField("MAPID", "MAPID", JdeDataType.String, 20),
        new JdeField("MAJOBN", "MAJOBN", JdeDataType.String, 20),
        new JdeField("MAUPMT", "MAUPMT", JdeDataType.Numeric),
        new JdeField("MASYNCS", "MASYNCS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0150_0", "Primary Key on MAOSTP, MAPA8, MAAN8", new[] { "MAOSTP", "MAPA8", "MAAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0150_2", "Unique Index on MAOSTP, MAAN8, MAPA8", new[] { "MAOSTP", "MAAN8", "MAPA8" }, isUnique: true),
        new JdeIndex("F0150_3", "Index on MAPA8", new[] { "MAPA8" }),
        new JdeIndex("F0150_4", "Index on MAAN8", new[] { "MAAN8" }),
        new JdeIndex("F0150_5", "Index on MAOSTP, MAAN8", new[] { "MAOSTP", "MAAN8" }),
        new JdeIndex("F0150_6", "Index on MAOSTP, MAPA8", new[] { "MAOSTP", "MAPA8" }),
        new JdeIndex("F0150_7", "Index on MAOSTP, MAPA8, MADSS7", new[] { "MAOSTP", "MAPA8", "MADSS7" }),
        new JdeIndex("F0150_8", "Index on MAOSTP, MAAN8, SYS_NC00014$", new[] { "MAOSTP", "MAAN8", "SYS_NC00014$" })
    };
}
