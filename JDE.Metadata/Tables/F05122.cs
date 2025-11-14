using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05122 - .
/// </summary>
public class F05122 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APACPL.
        /// </summary>
        public const string APACPL = "APACPL";

        /// <summary>
        /// APAN8.
        /// </summary>
        public const string APAN8 = "APAN8";

        /// <summary>
        /// APDL01.
        /// </summary>
        public const string APDL01 = "APDL01";

        /// <summary>
        /// APEFT.
        /// </summary>
        public const string APEFT = "APEFT";

        /// <summary>
        /// APECD.
        /// </summary>
        public const string APECD = "APECD";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05122";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APACPL", "APACPL", JdeDataType.Numeric, null, true, true),
        new JdeField("APAN8", "APAN8", JdeDataType.Numeric),
        new JdeField("APDL01", "APDL01", JdeDataType.String, 60),
        new JdeField("APEFT", "APEFT", JdeDataType.Numeric),
        new JdeField("APECD", "APECD", JdeDataType.Numeric),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05122_0", "Primary Key on APACPL", new[] { "APACPL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05122_2", "Index on APAN8, APACPL", new[] { "APAN8", "APACPL" })
    };
}
