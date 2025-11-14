using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW93 - .
/// </summary>
public class FCW93 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STMCUF.
        /// </summary>
        public const string STMCUF = "STMCUF";

        /// <summary>
        /// STITM.
        /// </summary>
        public const string STITM = "STITM";

        /// <summary>
        /// STJBCD.
        /// </summary>
        public const string STJBCD = "STJBCD";

        /// <summary>
        /// STMCU.
        /// </summary>
        public const string STMCU = "STMCU";

        /// <summary>
        /// STCMCU.
        /// </summary>
        public const string STCMCU = "STCMCU";

        /// <summary>
        /// STITC.
        /// </summary>
        public const string STITC = "STITC";

        /// <summary>
        /// STLOCN.
        /// </summary>
        public const string STLOCN = "STLOCN";

        /// <summary>
        /// STVEND.
        /// </summary>
        public const string STVEND = "STVEND";

        /// <summary>
        /// STMMCU.
        /// </summary>
        public const string STMMCU = "STMMCU";

        /// <summary>
        /// STQUED.
        /// </summary>
        public const string STQUED = "STQUED";

        /// <summary>
        /// STPRRC.
        /// </summary>
        public const string STPRRC = "STPRRC";

        /// <summary>
        /// STCRCD.
        /// </summary>
        public const string STCRCD = "STCRCD";

        /// <summary>
        /// STEFTJ.
        /// </summary>
        public const string STEFTJ = "STEFTJ";

        /// <summary>
        /// STEXDJ.
        /// </summary>
        public const string STEXDJ = "STEXDJ";

        /// <summary>
        /// STC9STS.
        /// </summary>
        public const string STC9STS = "STC9STS";
    }

    /// <inheritdoc />
    public override string TableName => "FCW93";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STMCUF", "STMCUF", JdeDataType.String, 24, true, true),
        new JdeField("STITM", "STITM", JdeDataType.Numeric, null, true, true),
        new JdeField("STJBCD", "STJBCD", JdeDataType.String, 12, true, true),
        new JdeField("STMCU", "STMCU", JdeDataType.String, 24, true, true),
        new JdeField("STCMCU", "STCMCU", JdeDataType.String, 24),
        new JdeField("STITC", "STITC", JdeDataType.String, 2),
        new JdeField("STLOCN", "STLOCN", JdeDataType.String, 40),
        new JdeField("STVEND", "STVEND", JdeDataType.Numeric),
        new JdeField("STMMCU", "STMMCU", JdeDataType.String, 24),
        new JdeField("STQUED", "STQUED", JdeDataType.Numeric),
        new JdeField("STPRRC", "STPRRC", JdeDataType.Numeric),
        new JdeField("STCRCD", "STCRCD", JdeDataType.String, 6),
        new JdeField("STEFTJ", "STEFTJ", JdeDataType.Numeric),
        new JdeField("STEXDJ", "STEXDJ", JdeDataType.Numeric),
        new JdeField("STC9STS", "STC9STS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW93_0", "Primary Key on STMCUF, STITM, STJBCD, STMCU", new[] { "STMCUF", "STITM", "STJBCD", "STMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
