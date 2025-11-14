using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G20W - .
/// </summary>
public class F52G20W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LWJOBS.
        /// </summary>
        public const string LWJOBS = "LWJOBS";

        /// <summary>
        /// LWSEQ.
        /// </summary>
        public const string LWSEQ = "LWSEQ";

        /// <summary>
        /// LWDOCO.
        /// </summary>
        public const string LWDOCO = "LWDOCO";

        /// <summary>
        /// LWPCTN.
        /// </summary>
        public const string LWPCTN = "LWPCTN";

        /// <summary>
        /// LWCLNU.
        /// </summary>
        public const string LWCLNU = "LWCLNU";

        /// <summary>
        /// LWMCU.
        /// </summary>
        public const string LWMCU = "LWMCU";

        /// <summary>
        /// LWJBCD.
        /// </summary>
        public const string LWJBCD = "LWJBCD";

        /// <summary>
        /// LWDESC.
        /// </summary>
        public const string LWDESC = "LWDESC";

        /// <summary>
        /// LWLBRTY.
        /// </summary>
        public const string LWLBRTY = "LWLBRTY";

        /// <summary>
        /// LWCTF1.
        /// </summary>
        public const string LWCTF1 = "LWCTF1";

        /// <summary>
        /// LWFEEC.
        /// </summary>
        public const string LWFEEC = "LWFEEC";

        /// <summary>
        /// LWLOEHRS.
        /// </summary>
        public const string LWLOEHRS = "LWLOEHRS";

        /// <summary>
        /// LWFRTYP.
        /// </summary>
        public const string LWFRTYP = "LWFRTYP";

        /// <summary>
        /// LWFEERT.
        /// </summary>
        public const string LWFEERT = "LWFEERT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G20W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LWJOBS", "LWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("LWSEQ", "LWSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LWDOCO", "LWDOCO", JdeDataType.Numeric),
        new JdeField("LWPCTN", "LWPCTN", JdeDataType.Numeric),
        new JdeField("LWCLNU", "LWCLNU", JdeDataType.Numeric),
        new JdeField("LWMCU", "LWMCU", JdeDataType.String, 24),
        new JdeField("LWJBCD", "LWJBCD", JdeDataType.String, 12),
        new JdeField("LWDESC", "LWDESC", JdeDataType.String, 60),
        new JdeField("LWLBRTY", "LWLBRTY", JdeDataType.String, 8),
        new JdeField("LWCTF1", "LWCTF1", JdeDataType.String, 2),
        new JdeField("LWFEEC", "LWFEEC", JdeDataType.String, 2),
        new JdeField("LWLOEHRS", "LWLOEHRS", JdeDataType.Numeric),
        new JdeField("LWFRTYP", "LWFRTYP", JdeDataType.String, 2),
        new JdeField("LWFEERT", "LWFEERT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G20W_0", "Primary Key on LWJOBS, LWSEQ", new[] { "LWJOBS", "LWSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
