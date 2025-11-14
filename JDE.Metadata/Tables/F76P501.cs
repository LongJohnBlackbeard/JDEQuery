using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P501 - .
/// </summary>
public class F76P501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DACO.
        /// </summary>
        public const string DACO = "DACO";

        /// <summary>
        /// DADAOB.
        /// </summary>
        public const string DADAOB = "DADAOB";

        /// <summary>
        /// DADASB.
        /// </summary>
        public const string DADASB = "DADASB";

        /// <summary>
        /// DAAMCU.
        /// </summary>
        public const string DAAMCU = "DAAMCU";

        /// <summary>
        /// DAAOBJ.
        /// </summary>
        public const string DAAOBJ = "DAAOBJ";

        /// <summary>
        /// DAASUB.
        /// </summary>
        public const string DAASUB = "DAASUB";

        /// <summary>
        /// DADMCU.
        /// </summary>
        public const string DADMCU = "DADMCU";

        /// <summary>
        /// DADOBJ.
        /// </summary>
        public const string DADOBJ = "DADOBJ";

        /// <summary>
        /// DADSUB.
        /// </summary>
        public const string DADSUB = "DADSUB";

        /// <summary>
        /// DAUSER.
        /// </summary>
        public const string DAUSER = "DAUSER";

        /// <summary>
        /// DAPID.
        /// </summary>
        public const string DAPID = "DAPID";

        /// <summary>
        /// DAJOBN.
        /// </summary>
        public const string DAJOBN = "DAJOBN";

        /// <summary>
        /// DAUPMJ.
        /// </summary>
        public const string DAUPMJ = "DAUPMJ";

        /// <summary>
        /// DAUPMT.
        /// </summary>
        public const string DAUPMT = "DAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DACO", "DACO", JdeDataType.String, 10, true, true),
        new JdeField("DADAOB", "DADAOB", JdeDataType.String, 12, true, true),
        new JdeField("DADASB", "DADASB", JdeDataType.String, 16, true, true),
        new JdeField("DAAMCU", "DAAMCU", JdeDataType.String, 24),
        new JdeField("DAAOBJ", "DAAOBJ", JdeDataType.String, 12),
        new JdeField("DAASUB", "DAASUB", JdeDataType.String, 16),
        new JdeField("DADMCU", "DADMCU", JdeDataType.String, 24),
        new JdeField("DADOBJ", "DADOBJ", JdeDataType.String, 12),
        new JdeField("DADSUB", "DADSUB", JdeDataType.String, 16),
        new JdeField("DAUSER", "DAUSER", JdeDataType.String, 20),
        new JdeField("DAPID", "DAPID", JdeDataType.String, 20),
        new JdeField("DAJOBN", "DAJOBN", JdeDataType.String, 20),
        new JdeField("DAUPMJ", "DAUPMJ", JdeDataType.Numeric),
        new JdeField("DAUPMT", "DAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P501_0", "Primary Key on DACO, DADAOB, DADASB", new[] { "DACO", "DADAOB", "DADASB" }, isUnique: true, isPrimaryKey: true)
    };
}
