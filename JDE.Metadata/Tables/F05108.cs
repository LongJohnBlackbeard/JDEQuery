using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05108 - .
/// </summary>
public class F05108 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UTUKID.
        /// </summary>
        public const string UTUKID = "UTUKID";

        /// <summary>
        /// UTTYP01.
        /// </summary>
        public const string UTTYP01 = "UTTYP01";

        /// <summary>
        /// UTINEC.
        /// </summary>
        public const string UTINEC = "UTINEC";

        /// <summary>
        /// UTPDL01.
        /// </summary>
        public const string UTPDL01 = "UTPDL01";

        /// <summary>
        /// UTGCODE.
        /// </summary>
        public const string UTGCODE = "UTGCODE";

        /// <summary>
        /// UTGDL01.
        /// </summary>
        public const string UTGDL01 = "UTGDL01";

        /// <summary>
        /// UTABBR.
        /// </summary>
        public const string UTABBR = "UTABBR";

        /// <summary>
        /// UTENTRD.
        /// </summary>
        public const string UTENTRD = "UTENTRD";

        /// <summary>
        /// UTDENT0.
        /// </summary>
        public const string UTDENT0 = "UTDENT0";

        /// <summary>
        /// UTEESTS.
        /// </summary>
        public const string UTEESTS = "UTEESTS";

        /// <summary>
        /// UTUSER.
        /// </summary>
        public const string UTUSER = "UTUSER";

        /// <summary>
        /// UTPID.
        /// </summary>
        public const string UTPID = "UTPID";

        /// <summary>
        /// UTMKEY.
        /// </summary>
        public const string UTMKEY = "UTMKEY";

        /// <summary>
        /// UTUPMJ.
        /// </summary>
        public const string UTUPMJ = "UTUPMJ";

        /// <summary>
        /// UTUPMT.
        /// </summary>
        public const string UTUPMT = "UTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05108";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UTUKID", "UTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("UTTYP01", "UTTYP01", JdeDataType.String, 2),
        new JdeField("UTINEC", "UTINEC", JdeDataType.String, 20),
        new JdeField("UTPDL01", "UTPDL01", JdeDataType.String, 60),
        new JdeField("UTGCODE", "UTGCODE", JdeDataType.String, 20),
        new JdeField("UTGDL01", "UTGDL01", JdeDataType.String, 60),
        new JdeField("UTABBR", "UTABBR", JdeDataType.String, 20),
        new JdeField("UTENTRD", "UTENTRD", JdeDataType.Numeric),
        new JdeField("UTDENT0", "UTDENT0", JdeDataType.Numeric),
        new JdeField("UTEESTS", "UTEESTS", JdeDataType.Numeric),
        new JdeField("UTUSER", "UTUSER", JdeDataType.String, 20),
        new JdeField("UTPID", "UTPID", JdeDataType.String, 20),
        new JdeField("UTMKEY", "UTMKEY", JdeDataType.String, 30),
        new JdeField("UTUPMJ", "UTUPMJ", JdeDataType.Numeric),
        new JdeField("UTUPMT", "UTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05108_0", "Primary Key on UTUKID", new[] { "UTUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
