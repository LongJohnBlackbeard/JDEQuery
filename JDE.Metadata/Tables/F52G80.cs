using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G80 - .
/// </summary>
public class F52G80 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGARGR.
        /// </summary>
        public const string AGARGR = "AGARGR";

        /// <summary>
        /// AGARLNID.
        /// </summary>
        public const string AGARLNID = "AGARLNID";

        /// <summary>
        /// AGDL01.
        /// </summary>
        public const string AGDL01 = "AGDL01";

        /// <summary>
        /// AGOBJBEG.
        /// </summary>
        public const string AGOBJBEG = "AGOBJBEG";

        /// <summary>
        /// AGOBJEND.
        /// </summary>
        public const string AGOBJEND = "AGOBJEND";

        /// <summary>
        /// AGUSER.
        /// </summary>
        public const string AGUSER = "AGUSER";

        /// <summary>
        /// AGPID.
        /// </summary>
        public const string AGPID = "AGPID";

        /// <summary>
        /// AGMKEY.
        /// </summary>
        public const string AGMKEY = "AGMKEY";

        /// <summary>
        /// AGUPMJ.
        /// </summary>
        public const string AGUPMJ = "AGUPMJ";

        /// <summary>
        /// AGUPMT.
        /// </summary>
        public const string AGUPMT = "AGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G80";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGARGR", "AGARGR", JdeDataType.String, 8, true, true),
        new JdeField("AGARLNID", "AGARLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("AGDL01", "AGDL01", JdeDataType.String, 60),
        new JdeField("AGOBJBEG", "AGOBJBEG", JdeDataType.String, 12),
        new JdeField("AGOBJEND", "AGOBJEND", JdeDataType.String, 12),
        new JdeField("AGUSER", "AGUSER", JdeDataType.String, 20),
        new JdeField("AGPID", "AGPID", JdeDataType.String, 20),
        new JdeField("AGMKEY", "AGMKEY", JdeDataType.String, 30),
        new JdeField("AGUPMJ", "AGUPMJ", JdeDataType.Numeric),
        new JdeField("AGUPMT", "AGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G80_0", "Primary Key on AGARGR, AGARLNID", new[] { "AGARGR", "AGARLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G80_2", "Index on AGARGR, AGOBJBEG", new[] { "AGARGR", "AGOBJBEG" }),
        new JdeIndex("F52G80_3", "Index on AGARGR, SYS_NC00011$", new[] { "AGARGR", "SYS_NC00011$" })
    };
}
