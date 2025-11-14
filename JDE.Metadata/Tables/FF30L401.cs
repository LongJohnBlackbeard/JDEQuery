using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L401 - .
/// </summary>
public class FF30L401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SMSUPN.
        /// </summary>
        public const string SMSUPN = "SMSUPN";

        /// <summary>
        /// SMFSCID.
        /// </summary>
        public const string SMFSCID = "SMFSCID";

        /// <summary>
        /// SMNAMED.
        /// </summary>
        public const string SMNAMED = "SMNAMED";

        /// <summary>
        /// SMRMK.
        /// </summary>
        public const string SMRMK = "SMRMK";

        /// <summary>
        /// SMURCD.
        /// </summary>
        public const string SMURCD = "SMURCD";

        /// <summary>
        /// SMURDT.
        /// </summary>
        public const string SMURDT = "SMURDT";

        /// <summary>
        /// SMURAT.
        /// </summary>
        public const string SMURAT = "SMURAT";

        /// <summary>
        /// SMURAB.
        /// </summary>
        public const string SMURAB = "SMURAB";

        /// <summary>
        /// SMURRF.
        /// </summary>
        public const string SMURRF = "SMURRF";

        /// <summary>
        /// SMUSER.
        /// </summary>
        public const string SMUSER = "SMUSER";

        /// <summary>
        /// SMPID.
        /// </summary>
        public const string SMPID = "SMPID";

        /// <summary>
        /// SMMKEY.
        /// </summary>
        public const string SMMKEY = "SMMKEY";

        /// <summary>
        /// SMUUPMJ.
        /// </summary>
        public const string SMUUPMJ = "SMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SMSUPN", "SMSUPN", JdeDataType.Numeric, null, true, true),
        new JdeField("SMFSCID", "SMFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("SMNAMED", "SMNAMED", JdeDataType.String, 80),
        new JdeField("SMRMK", "SMRMK", JdeDataType.String, 60),
        new JdeField("SMURCD", "SMURCD", JdeDataType.String, 4),
        new JdeField("SMURDT", "SMURDT", JdeDataType.Numeric),
        new JdeField("SMURAT", "SMURAT", JdeDataType.Numeric),
        new JdeField("SMURAB", "SMURAB", JdeDataType.Numeric),
        new JdeField("SMURRF", "SMURRF", JdeDataType.String, 30),
        new JdeField("SMUSER", "SMUSER", JdeDataType.String, 20),
        new JdeField("SMPID", "SMPID", JdeDataType.String, 20),
        new JdeField("SMMKEY", "SMMKEY", JdeDataType.String, 30),
        new JdeField("SMUUPMJ", "SMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L401_0", "Primary Key on SMSUPN, SMFSCID", new[] { "SMSUPN", "SMFSCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L401_2", "Index on SMFSCID", new[] { "SMFSCID" })
    };
}
