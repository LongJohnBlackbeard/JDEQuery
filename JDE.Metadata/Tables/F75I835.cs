using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I835 - .
/// </summary>
public class F75I835 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLI75TXRG.
        /// </summary>
        public const string GLI75TXRG = "GLI75TXRG";

        /// <summary>
        /// GLI75TXTY.
        /// </summary>
        public const string GLI75TXTY = "GLI75TXTY";

        /// <summary>
        /// GLGLC.
        /// </summary>
        public const string GLGLC = "GLGLC";

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

        /// <summary>
        /// GLYFUTDT1.
        /// </summary>
        public const string GLYFUTDT1 = "GLYFUTDT1";

        /// <summary>
        /// GLFUT6.
        /// </summary>
        public const string GLFUT6 = "GLFUT6";

        /// <summary>
        /// GLYT04.
        /// </summary>
        public const string GLYT04 = "GLYT04";

        /// <summary>
        /// GLYFLAG.
        /// </summary>
        public const string GLYFLAG = "GLYFLAG";

        /// <summary>
        /// GLYNUM1.
        /// </summary>
        public const string GLYNUM1 = "GLYNUM1";

        /// <summary>
        /// GLAN8.
        /// </summary>
        public const string GLAN8 = "GLAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F75I835";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10, true, true),
        new JdeField("GLI75TXRG", "GLI75TXRG", JdeDataType.String, 10, true, true),
        new JdeField("GLI75TXTY", "GLI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("GLGLC", "GLGLC", JdeDataType.String, 8),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric),
        new JdeField("GLYFUTDT1", "GLYFUTDT1", JdeDataType.Numeric),
        new JdeField("GLFUT6", "GLFUT6", JdeDataType.String, 60),
        new JdeField("GLYT04", "GLYT04", JdeDataType.String, 2),
        new JdeField("GLYFLAG", "GLYFLAG", JdeDataType.String, 2),
        new JdeField("GLYNUM1", "GLYNUM1", JdeDataType.Numeric),
        new JdeField("GLAN8", "GLAN8", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I835_0", "Primary Key on GLCO, GLI75TXRG, GLI75TXTY, GLAN8", new[] { "GLCO", "GLI75TXRG", "GLI75TXTY", "GLAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
