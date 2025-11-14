using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700101 - .
/// </summary>
public class F700101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLSY.
        /// </summary>
        public const string GLSY = "GLSY";

        /// <summary>
        /// GLLCTR.
        /// </summary>
        public const string GLLCTR = "GLLCTR";

        /// <summary>
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLGL01.
        /// </summary>
        public const string GLGL01 = "GLGL01";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLUPMJ.
        /// </summary>
        public const string GLUPMJ = "GLUPMJ";

        /// <summary>
        /// GLUPMT.
        /// </summary>
        public const string GLUPMT = "GLUPMT";

        /// <summary>
        /// GLJOBN.
        /// </summary>
        public const string GLJOBN = "GLJOBN";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";
    }

    /// <inheritdoc />
    public override string TableName => "F700101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLSY", "GLSY", JdeDataType.String, 8, true, true),
        new JdeField("GLLCTR", "GLLCTR", JdeDataType.String, 6, true, true),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10, true, true),
        new JdeField("GLGL01", "GLGL01", JdeDataType.String, 8, true, true),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLUPMT", "GLUPMT", JdeDataType.Numeric),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700101_0", "Primary Key on GLSY, GLLCTR, GLCO, GLGL01", new[] { "GLSY", "GLLCTR", "GLCO", "GLGL01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F700101_2", "Index on GLSY, GLLCTR", new[] { "GLSY", "GLLCTR" })
    };
}
