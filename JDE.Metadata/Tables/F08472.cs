using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08472 - .
/// </summary>
public class F08472 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JTPSTNO.
        /// </summary>
        public const string JTPSTNO = "JTPSTNO";

        /// <summary>
        /// JTLANG.
        /// </summary>
        public const string JTLANG = "JTLANG";

        /// <summary>
        /// JTPSTDSC.
        /// </summary>
        public const string JTPSTDSC = "JTPSTDSC";

        /// <summary>
        /// JTKEYWRD.
        /// </summary>
        public const string JTKEYWRD = "JTKEYWRD";

        /// <summary>
        /// JTPID.
        /// </summary>
        public const string JTPID = "JTPID";

        /// <summary>
        /// JTUSER.
        /// </summary>
        public const string JTUSER = "JTUSER";

        /// <summary>
        /// JTMKEY.
        /// </summary>
        public const string JTMKEY = "JTMKEY";

        /// <summary>
        /// JTUPMJ.
        /// </summary>
        public const string JTUPMJ = "JTUPMJ";

        /// <summary>
        /// JTUPMT.
        /// </summary>
        public const string JTUPMT = "JTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08472";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JTPSTNO", "JTPSTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("JTLANG", "JTLANG", JdeDataType.String, 4, true, true),
        new JdeField("JTPSTDSC", "JTPSTDSC", JdeDataType.String, 160),
        new JdeField("JTKEYWRD", "JTKEYWRD", JdeDataType.String, 1000),
        new JdeField("JTPID", "JTPID", JdeDataType.String, 20),
        new JdeField("JTUSER", "JTUSER", JdeDataType.String, 20),
        new JdeField("JTMKEY", "JTMKEY", JdeDataType.String, 30),
        new JdeField("JTUPMJ", "JTUPMJ", JdeDataType.Numeric),
        new JdeField("JTUPMT", "JTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08472_0", "Primary Key on JTPSTNO, JTLANG", new[] { "JTPSTNO", "JTLANG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08472_2", "Index on JTPSTNO", new[] { "JTPSTNO" })
    };
}
