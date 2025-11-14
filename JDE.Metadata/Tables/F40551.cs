using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40551 - .
/// </summary>
public class F40551 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLMCU.
        /// </summary>
        public const string GLMCU = "GLMCU";

        /// <summary>
        /// GLOBJ.
        /// </summary>
        public const string GLOBJ = "GLOBJ";

        /// <summary>
        /// GLSUB.
        /// </summary>
        public const string GLSUB = "GLSUB";

        /// <summary>
        /// GLCMDCDE.
        /// </summary>
        public const string GLCMDCDE = "GLCMDCDE";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLJOBN.
        /// </summary>
        public const string GLJOBN = "GLJOBN";

        /// <summary>
        /// GLUPMJ.
        /// </summary>
        public const string GLUPMJ = "GLUPMJ";

        /// <summary>
        /// GLUPMT.
        /// </summary>
        public const string GLUPMT = "GLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F40551";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLMCU", "GLMCU", JdeDataType.String, 24, true, true),
        new JdeField("GLOBJ", "GLOBJ", JdeDataType.String, 12, true, true),
        new JdeField("GLSUB", "GLSUB", JdeDataType.String, 16, true, true),
        new JdeField("GLCMDCDE", "GLCMDCDE", JdeDataType.String, 30),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40551_0", "Primary Key on GLMCU, GLOBJ, GLSUB", new[] { "GLMCU", "GLOBJ", "GLSUB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40551_2", "Index on GLCMDCDE", new[] { "GLCMDCDE" })
    };
}
