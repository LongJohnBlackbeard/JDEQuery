using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C4106 - .
/// </summary>
public class F75C4106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBITM.
        /// </summary>
        public const string IBITM = "IBITM";

        /// <summary>
        /// IBUOM4.
        /// </summary>
        public const string IBUOM4 = "IBUOM4";

        /// <summary>
        /// IBMCU.
        /// </summary>
        public const string IBMCU = "IBMCU";

        /// <summary>
        /// IBLOCN.
        /// </summary>
        public const string IBLOCN = "IBLOCN";

        /// <summary>
        /// IBLOTN.
        /// </summary>
        public const string IBLOTN = "IBLOTN";

        /// <summary>
        /// IBEFTJ.
        /// </summary>
        public const string IBEFTJ = "IBEFTJ";

        /// <summary>
        /// IBAITM.
        /// </summary>
        public const string IBAITM = "IBAITM";

        /// <summary>
        /// IBLITM.
        /// </summary>
        public const string IBLITM = "IBLITM";

        /// <summary>
        /// IBEXDJ.
        /// </summary>
        public const string IBEXDJ = "IBEXDJ";

        /// <summary>
        /// IBUPRC.
        /// </summary>
        public const string IBUPRC = "IBUPRC";

        /// <summary>
        /// IBUSER.
        /// </summary>
        public const string IBUSER = "IBUSER";

        /// <summary>
        /// IBPID.
        /// </summary>
        public const string IBPID = "IBPID";

        /// <summary>
        /// IBJOBN.
        /// </summary>
        public const string IBJOBN = "IBJOBN";

        /// <summary>
        /// IBUPMJ.
        /// </summary>
        public const string IBUPMJ = "IBUPMJ";

        /// <summary>
        /// IBUPMT.
        /// </summary>
        public const string IBUPMT = "IBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C4106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBITM", "IBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IBUOM4", "IBUOM4", JdeDataType.String, 4, true, true),
        new JdeField("IBMCU", "IBMCU", JdeDataType.String, 24, true, true),
        new JdeField("IBLOCN", "IBLOCN", JdeDataType.String, 40, true, true),
        new JdeField("IBLOTN", "IBLOTN", JdeDataType.String, 60, true, true),
        new JdeField("IBEFTJ", "IBEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("IBAITM", "IBAITM", JdeDataType.String, 50),
        new JdeField("IBLITM", "IBLITM", JdeDataType.String, 50),
        new JdeField("IBEXDJ", "IBEXDJ", JdeDataType.Numeric),
        new JdeField("IBUPRC", "IBUPRC", JdeDataType.Numeric),
        new JdeField("IBUSER", "IBUSER", JdeDataType.String, 20),
        new JdeField("IBPID", "IBPID", JdeDataType.String, 20),
        new JdeField("IBJOBN", "IBJOBN", JdeDataType.String, 20),
        new JdeField("IBUPMJ", "IBUPMJ", JdeDataType.Numeric),
        new JdeField("IBUPMT", "IBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C4106_0", "Primary Key on IBITM, IBUOM4, IBMCU, IBLOCN, IBLOTN, IBEFTJ", new[] { "IBITM", "IBUOM4", "IBMCU", "IBLOCN", "IBLOTN", "IBEFTJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75C4106_2", "Index on IBITM, IBUOM4, IBMCU, IBLOCN, IBLOTN, IBEXDJ", new[] { "IBITM", "IBUOM4", "IBMCU", "IBLOCN", "IBLOTN", "IBEXDJ" })
    };
}
