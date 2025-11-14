using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43S002 - .
/// </summary>
public class F43S002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACALRTSL.
        /// </summary>
        public const string ACALRTSL = "ACALRTSL";

        /// <summary>
        /// ACSRMALERT.
        /// </summary>
        public const string ACSRMALERT = "ACSRMALERT";

        /// <summary>
        /// ACALERTDES.
        /// </summary>
        public const string ACALERTDES = "ACALERTDES";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACVERS.
        /// </summary>
        public const string ACVERS = "ACVERS";

        /// <summary>
        /// ACALRTLBL.
        /// </summary>
        public const string ACALRTLBL = "ACALRTLBL";

        /// <summary>
        /// ACALUGRL.
        /// </summary>
        public const string ACALUGRL = "ACALUGRL";

        /// <summary>
        /// ACALPARLS.
        /// </summary>
        public const string ACALPARLS = "ACALPARLS";

        /// <summary>
        /// ACALPARRS.
        /// </summary>
        public const string ACALPARRS = "ACALPARRS";

        /// <summary>
        /// ACAOSC.
        /// </summary>
        public const string ACAOSC = "ACAOSC";

        /// <summary>
        /// ACALPARDT.
        /// </summary>
        public const string ACALPARDT = "ACALPARDT";

        /// <summary>
        /// ACOPRC.
        /// </summary>
        public const string ACOPRC = "ACOPRC";

        /// <summary>
        /// ACALDMCP.
        /// </summary>
        public const string ACALDMCP = "ACALDMCP";

        /// <summary>
        /// ACAN8.
        /// </summary>
        public const string ACAN8 = "ACAN8";

        /// <summary>
        /// ACPOISD.
        /// </summary>
        public const string ACPOISD = "ACPOISD";

        /// <summary>
        /// ACSTRT.
        /// </summary>
        public const string ACSTRT = "ACSTRT";

        /// <summary>
        /// ACGENQJ.
        /// </summary>
        public const string ACGENQJ = "ACGENQJ";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";

        /// <summary>
        /// ACALCFGS1.
        /// </summary>
        public const string ACALCFGS1 = "ACALCFGS1";

        /// <summary>
        /// ACALCFGS2.
        /// </summary>
        public const string ACALCFGS2 = "ACALCFGS2";

        /// <summary>
        /// ACALCFGS3.
        /// </summary>
        public const string ACALCFGS3 = "ACALCFGS3";

        /// <summary>
        /// ACALRTDJ1.
        /// </summary>
        public const string ACALRTDJ1 = "ACALRTDJ1";

        /// <summary>
        /// ACALRTDJ2.
        /// </summary>
        public const string ACALRTDJ2 = "ACALRTDJ2";
    }

    /// <inheritdoc />
    public override string TableName => "F43S002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACALRTSL", "ACALRTSL", JdeDataType.Numeric, null, true, true),
        new JdeField("ACSRMALERT", "ACSRMALERT", JdeDataType.Numeric),
        new JdeField("ACALERTDES", "ACALERTDES", JdeDataType.String, 300),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20, true, true),
        new JdeField("ACVERS", "ACVERS", JdeDataType.String, 20),
        new JdeField("ACALRTLBL", "ACALRTLBL", JdeDataType.String, 300),
        new JdeField("ACALUGRL", "ACALUGRL", JdeDataType.String, 2),
        new JdeField("ACALPARLS", "ACALPARLS", JdeDataType.String, 1000),
        new JdeField("ACALPARRS", "ACALPARRS", JdeDataType.String, 1000),
        new JdeField("ACAOSC", "ACAOSC", JdeDataType.String, 6),
        new JdeField("ACALPARDT", "ACALPARDT", JdeDataType.String, 1000),
        new JdeField("ACOPRC", "ACOPRC", JdeDataType.String, 8),
        new JdeField("ACALDMCP", "ACALDMCP", JdeDataType.String, 2),
        new JdeField("ACAN8", "ACAN8", JdeDataType.Numeric),
        new JdeField("ACPOISD", "ACPOISD", JdeDataType.String, 4),
        new JdeField("ACSTRT", "ACSTRT", JdeDataType.Numeric),
        new JdeField("ACGENQJ", "ACGENQJ", JdeDataType.Numeric),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric),
        new JdeField("ACALCFGS1", "ACALCFGS1", JdeDataType.String, 1000),
        new JdeField("ACALCFGS2", "ACALCFGS2", JdeDataType.String, 1000),
        new JdeField("ACALCFGS3", "ACALCFGS3", JdeDataType.String, 1000),
        new JdeField("ACALRTDJ1", "ACALRTDJ1", JdeDataType.Numeric),
        new JdeField("ACALRTDJ2", "ACALRTDJ2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43S002_0", "Primary Key on ACUSER, ACALRTSL", new[] { "ACUSER", "ACALRTSL" }, isUnique: true, isPrimaryKey: true)
    };
}
