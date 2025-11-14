using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B955 - .
/// </summary>
public class F76B955 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLJOBS.
        /// </summary>
        public const string GLJOBS = "GLJOBS";

        /// <summary>
        /// GLAID.
        /// </summary>
        public const string GLAID = "GLAID";

        /// <summary>
        /// GLB76PAID.
        /// </summary>
        public const string GLB76PAID = "GLB76PAID";

        /// <summary>
        /// GLB76PMCU.
        /// </summary>
        public const string GLB76PMCU = "GLB76PMCU";

        /// <summary>
        /// GLB76POBJ.
        /// </summary>
        public const string GLB76POBJ = "GLB76POBJ";

        /// <summary>
        /// GLB76PSUB.
        /// </summary>
        public const string GLB76PSUB = "GLB76PSUB";

        /// <summary>
        /// GLB76AGLL.
        /// </summary>
        public const string GLB76AGLL = "GLB76AGLL";

        /// <summary>
        /// GLB76AGTC.
        /// </summary>
        public const string GLB76AGTC = "GLB76AGTC";

        /// <summary>
        /// GLB76AGL2.
        /// </summary>
        public const string GLB76AGL2 = "GLB76AGL2";

        /// <summary>
        /// GLB76AGL3.
        /// </summary>
        public const string GLB76AGL3 = "GLB76AGL3";

        /// <summary>
        /// GLB76AGL4.
        /// </summary>
        public const string GLB76AGL4 = "GLB76AGL4";

        /// <summary>
        /// GLB76AGL5.
        /// </summary>
        public const string GLB76AGL5 = "GLB76AGL5";

        /// <summary>
        /// GLB76AGL6.
        /// </summary>
        public const string GLB76AGL6 = "GLB76AGL6";

        /// <summary>
        /// GLB76AGL7.
        /// </summary>
        public const string GLB76AGL7 = "GLB76AGL7";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";

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
    public override string TableName => "F76B955";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLJOBS", "GLJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GLAID", "GLAID", JdeDataType.String, 16, true, true),
        new JdeField("GLB76PAID", "GLB76PAID", JdeDataType.String, 16),
        new JdeField("GLB76PMCU", "GLB76PMCU", JdeDataType.String, 24),
        new JdeField("GLB76POBJ", "GLB76POBJ", JdeDataType.String, 12),
        new JdeField("GLB76PSUB", "GLB76PSUB", JdeDataType.String, 16),
        new JdeField("GLB76AGLL", "GLB76AGLL", JdeDataType.String, 2),
        new JdeField("GLB76AGTC", "GLB76AGTC", JdeDataType.String, 2),
        new JdeField("GLB76AGL2", "GLB76AGL2", JdeDataType.Numeric),
        new JdeField("GLB76AGL3", "GLB76AGL3", JdeDataType.Numeric),
        new JdeField("GLB76AGL4", "GLB76AGL4", JdeDataType.Numeric),
        new JdeField("GLB76AGL5", "GLB76AGL5", JdeDataType.Numeric),
        new JdeField("GLB76AGL6", "GLB76AGL6", JdeDataType.Numeric),
        new JdeField("GLB76AGL7", "GLB76AGL7", JdeDataType.Numeric),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B955_0", "Primary Key on GLJOBS, GLAID", new[] { "GLJOBS", "GLAID" }, isUnique: true, isPrimaryKey: true)
    };
}
