using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08773 - .
/// </summary>
public class F08773 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XLTINC.
        /// </summary>
        public const string XLTINC = "XLTINC";

        /// <summary>
        /// XLHMCO.
        /// </summary>
        public const string XLHMCO = "XLHMCO";

        /// <summary>
        /// XLORMCU.
        /// </summary>
        public const string XLORMCU = "XLORMCU";

        /// <summary>
        /// XLPACM.
        /// </summary>
        public const string XLPACM = "XLPACM";

        /// <summary>
        /// XLSCLES.
        /// </summary>
        public const string XLSCLES = "XLSCLES";

        /// <summary>
        /// XLREQLS.
        /// </summary>
        public const string XLREQLS = "XLREQLS";

        /// <summary>
        /// XLESARQ.
        /// </summary>
        public const string XLESARQ = "XLESARQ";

        /// <summary>
        /// XLPABM.
        /// </summary>
        public const string XLPABM = "XLPABM";

        /// <summary>
        /// XLSCLEE.
        /// </summary>
        public const string XLSCLEE = "XLSCLEE";

        /// <summary>
        /// XLREQLE.
        /// </summary>
        public const string XLREQLE = "XLREQLE";

        /// <summary>
        /// XLUSER.
        /// </summary>
        public const string XLUSER = "XLUSER";

        /// <summary>
        /// XLPID.
        /// </summary>
        public const string XLPID = "XLPID";

        /// <summary>
        /// XLJOBN.
        /// </summary>
        public const string XLJOBN = "XLJOBN";

        /// <summary>
        /// XLUPMJ.
        /// </summary>
        public const string XLUPMJ = "XLUPMJ";

        /// <summary>
        /// XLUPMT.
        /// </summary>
        public const string XLUPMT = "XLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08773";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XLTINC", "XLTINC", JdeDataType.String, 2, true, true),
        new JdeField("XLHMCO", "XLHMCO", JdeDataType.String, 10, true, true),
        new JdeField("XLORMCU", "XLORMCU", JdeDataType.String, 24, true, true),
        new JdeField("XLPACM", "XLPACM", JdeDataType.String, 2),
        new JdeField("XLSCLES", "XLSCLES", JdeDataType.String, 20),
        new JdeField("XLREQLS", "XLREQLS", JdeDataType.Numeric),
        new JdeField("XLESARQ", "XLESARQ", JdeDataType.String, 2),
        new JdeField("XLPABM", "XLPABM", JdeDataType.String, 2),
        new JdeField("XLSCLEE", "XLSCLEE", JdeDataType.String, 20),
        new JdeField("XLREQLE", "XLREQLE", JdeDataType.Numeric),
        new JdeField("XLUSER", "XLUSER", JdeDataType.String, 20),
        new JdeField("XLPID", "XLPID", JdeDataType.String, 20),
        new JdeField("XLJOBN", "XLJOBN", JdeDataType.String, 20),
        new JdeField("XLUPMJ", "XLUPMJ", JdeDataType.Numeric),
        new JdeField("XLUPMT", "XLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08773_0", "Primary Key on XLTINC, XLHMCO, XLORMCU", new[] { "XLTINC", "XLHMCO", "XLORMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
