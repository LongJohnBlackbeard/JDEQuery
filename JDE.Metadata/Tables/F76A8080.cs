using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8080 - .
/// </summary>
public class F76A8080 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NNCO.
        /// </summary>
        public const string NNCO = "NNCO";

        /// <summary>
        /// NNACEM.
        /// </summary>
        public const string NNACEM = "NNACEM";

        /// <summary>
        /// NNFYR.
        /// </summary>
        public const string NNFYR = "NNFYR";

        /// <summary>
        /// NNN001.
        /// </summary>
        public const string NNN001 = "NNN001";

        /// <summary>
        /// NNUSER.
        /// </summary>
        public const string NNUSER = "NNUSER";

        /// <summary>
        /// NNPID.
        /// </summary>
        public const string NNPID = "NNPID";

        /// <summary>
        /// NNUPMJ.
        /// </summary>
        public const string NNUPMJ = "NNUPMJ";

        /// <summary>
        /// NNUPMT.
        /// </summary>
        public const string NNUPMT = "NNUPMT";

        /// <summary>
        /// NNJOBN.
        /// </summary>
        public const string NNJOBN = "NNJOBN";

        /// <summary>
        /// NNACEM1.
        /// </summary>
        public const string NNACEM1 = "NNACEM1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8080";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NNCO", "NNCO", JdeDataType.String, 10, true, true),
        new JdeField("NNACEM", "NNACEM", JdeDataType.String, 8, true, true),
        new JdeField("NNFYR", "NNFYR", JdeDataType.Numeric, null, true, true),
        new JdeField("NNN001", "NNN001", JdeDataType.Numeric),
        new JdeField("NNUSER", "NNUSER", JdeDataType.String, 20),
        new JdeField("NNPID", "NNPID", JdeDataType.String, 20),
        new JdeField("NNUPMJ", "NNUPMJ", JdeDataType.Numeric),
        new JdeField("NNUPMT", "NNUPMT", JdeDataType.Numeric),
        new JdeField("NNJOBN", "NNJOBN", JdeDataType.String, 20),
        new JdeField("NNACEM1", "NNACEM1", JdeDataType.String, 30, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8080_0", "Primary Key on NNCO, NNACEM1, NNFYR, NNACEM", new[] { "NNCO", "NNACEM1", "NNFYR", "NNACEM" }, isUnique: true, isPrimaryKey: true)
    };
}
