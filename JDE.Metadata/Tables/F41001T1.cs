using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41001T1 - .
/// </summary>
public class F41001T1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CISY.
        /// </summary>
        public const string CISY = "CISY";

        /// <summary>
        /// CIMCU.
        /// </summary>
        public const string CIMCU = "CIMCU";

        /// <summary>
        /// CIQMCTR.
        /// </summary>
        public const string CIQMCTR = "CIQMCTR";

        /// <summary>
        /// CIUSER.
        /// </summary>
        public const string CIUSER = "CIUSER";

        /// <summary>
        /// CIPID.
        /// </summary>
        public const string CIPID = "CIPID";

        /// <summary>
        /// CIJOBN.
        /// </summary>
        public const string CIJOBN = "CIJOBN";

        /// <summary>
        /// CIUPMJ.
        /// </summary>
        public const string CIUPMJ = "CIUPMJ";

        /// <summary>
        /// CITDAY.
        /// </summary>
        public const string CITDAY = "CITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F41001T1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CISY", "CISY", JdeDataType.String, 8, true, true),
        new JdeField("CIMCU", "CIMCU", JdeDataType.String, 24, true, true),
        new JdeField("CIQMCTR", "CIQMCTR", JdeDataType.String, 2),
        new JdeField("CIUSER", "CIUSER", JdeDataType.String, 20),
        new JdeField("CIPID", "CIPID", JdeDataType.String, 20),
        new JdeField("CIJOBN", "CIJOBN", JdeDataType.String, 20),
        new JdeField("CIUPMJ", "CIUPMJ", JdeDataType.Numeric),
        new JdeField("CITDAY", "CITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41001T1_0", "Primary Key on CISY, CIMCU", new[] { "CISY", "CIMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
