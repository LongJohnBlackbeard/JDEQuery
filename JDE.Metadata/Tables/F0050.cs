using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0050 - .
/// </summary>
public class F0050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MAMCU1.
        /// </summary>
        public const string MAMCU1 = "MAMCU1";

        /// <summary>
        /// MAMCU.
        /// </summary>
        public const string MAMCU = "MAMCU";

        /// <summary>
        /// MAORSQ.
        /// </summary>
        public const string MAORSQ = "MAORSQ";

        /// <summary>
        /// MAOTPS.
        /// </summary>
        public const string MAOTPS = "MAOTPS";

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
    }

    /// <inheritdoc />
    public override string TableName => "F0050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MAMCU1", "MAMCU1", JdeDataType.String, 24, true, true),
        new JdeField("MAMCU", "MAMCU", JdeDataType.String, 24, true, true),
        new JdeField("MAORSQ", "MAORSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("MAOTPS", "MAOTPS", JdeDataType.String, 6, true, true),
        new JdeField("MABEFD", "MABEFD", JdeDataType.Numeric),
        new JdeField("MAEEFD", "MAEEFD", JdeDataType.Numeric),
        new JdeField("MARMK", "MARMK", JdeDataType.String, 60),
        new JdeField("MAUSER", "MAUSER", JdeDataType.String, 20),
        new JdeField("MAUPMJ", "MAUPMJ", JdeDataType.Numeric),
        new JdeField("MAPID", "MAPID", JdeDataType.String, 20),
        new JdeField("MAJOBN", "MAJOBN", JdeDataType.String, 20),
        new JdeField("MAUPMT", "MAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0050_0", "Primary Key on MAOTPS, MAMCU1, MAORSQ, MAMCU", new[] { "MAOTPS", "MAMCU1", "MAORSQ", "MAMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0050_2", "Index on MAMCU1", new[] { "MAMCU1" }),
        new JdeIndex("F0050_3", "Index on MAMCU", new[] { "MAMCU" }),
        new JdeIndex("F0050_4", "Index on MAOTPS, MAMCU", new[] { "MAOTPS", "MAMCU" })
    };
}
