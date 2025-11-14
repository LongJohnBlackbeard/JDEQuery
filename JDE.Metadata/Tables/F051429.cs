using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051429 - .
/// </summary>
public class F051429 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACACRYMID.
        /// </summary>
        public const string ACACRYMID = "ACACRYMID";

        /// <summary>
        /// ACACRORDER.
        /// </summary>
        public const string ACACRORDER = "ACACRORDER";

        /// <summary>
        /// ACMNWRD.
        /// </summary>
        public const string ACMNWRD = "ACMNWRD";

        /// <summary>
        /// ACWORDID.
        /// </summary>
        public const string ACWORDID = "ACWORDID";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACMKEY.
        /// </summary>
        public const string ACMKEY = "ACMKEY";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051429";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACACRYMID", "ACACRYMID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACACRORDER", "ACACRORDER", JdeDataType.Numeric, null, true, true),
        new JdeField("ACMNWRD", "ACMNWRD", JdeDataType.Numeric),
        new JdeField("ACWORDID", "ACWORDID", JdeDataType.Numeric),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACMKEY", "ACMKEY", JdeDataType.String, 30),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051429_0", "Primary Key on ACACRYMID, ACACRORDER", new[] { "ACACRYMID", "ACACRORDER" }, isUnique: true, isPrimaryKey: true)
    };
}
