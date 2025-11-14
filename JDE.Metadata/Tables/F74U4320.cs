using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4320 - .
/// </summary>
public class F74U4320 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TV74U43TV1.
        /// </summary>
        public const string TV74U43TV1 = "TV74U43TV1";

        /// <summary>
        /// TV74U43AK1.
        /// </summary>
        public const string TV74U43AK1 = "TV74U43AK1";

        /// <summary>
        /// TV74U43SQ1.
        /// </summary>
        public const string TV74U43SQ1 = "TV74U43SQ1";

        /// <summary>
        /// TVDESC.
        /// </summary>
        public const string TVDESC = "TVDESC";

        /// <summary>
        /// TV74U43RQ1.
        /// </summary>
        public const string TV74U43RQ1 = "TV74U43RQ1";

        /// <summary>
        /// TVUSER.
        /// </summary>
        public const string TVUSER = "TVUSER";

        /// <summary>
        /// TVPID.
        /// </summary>
        public const string TVPID = "TVPID";

        /// <summary>
        /// TVJOBN.
        /// </summary>
        public const string TVJOBN = "TVJOBN";

        /// <summary>
        /// TVUPMJ.
        /// </summary>
        public const string TVUPMJ = "TVUPMJ";

        /// <summary>
        /// TVUPMT.
        /// </summary>
        public const string TVUPMT = "TVUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4320";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TV74U43TV1", "TV74U43TV1", JdeDataType.String, 20, true, true),
        new JdeField("TV74U43AK1", "TV74U43AK1", JdeDataType.String, 20, true, true),
        new JdeField("TV74U43SQ1", "TV74U43SQ1", JdeDataType.Numeric),
        new JdeField("TVDESC", "TVDESC", JdeDataType.String, 60),
        new JdeField("TV74U43RQ1", "TV74U43RQ1", JdeDataType.String, 480),
        new JdeField("TVUSER", "TVUSER", JdeDataType.String, 20),
        new JdeField("TVPID", "TVPID", JdeDataType.String, 20),
        new JdeField("TVJOBN", "TVJOBN", JdeDataType.String, 20),
        new JdeField("TVUPMJ", "TVUPMJ", JdeDataType.Numeric),
        new JdeField("TVUPMT", "TVUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4320_0", "Primary Key on TV74U43TV1, TV74U43AK1", new[] { "TV74U43TV1", "TV74U43AK1" }, isUnique: true, isPrimaryKey: true)
    };
}
