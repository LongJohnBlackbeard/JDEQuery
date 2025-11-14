using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N1601 - .
/// </summary>
public class FD3N1601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHCNID.
        /// </summary>
        public const string PHCNID = "PHCNID";

        /// <summary>
        /// PHCK.
        /// </summary>
        public const string PHCK = "PHCK";

        /// <summary>
        /// PHSTA.
        /// </summary>
        public const string PHSTA = "PHSTA";

        /// <summary>
        /// PHLOCN.
        /// </summary>
        public const string PHLOCN = "PHLOCN";

        /// <summary>
        /// PHMCU.
        /// </summary>
        public const string PHMCU = "PHMCU";

        /// <summary>
        /// PHPTCNTP.
        /// </summary>
        public const string PHPTCNTP = "PHPTCNTP";

        /// <summary>
        /// PHAFWT.
        /// </summary>
        public const string PHAFWT = "PHAFWT";

        /// <summary>
        /// PHBFWT.
        /// </summary>
        public const string PHBFWT = "PHBFWT";

        /// <summary>
        /// PHAWGT.
        /// </summary>
        public const string PHAWGT = "PHAWGT";

        /// <summary>
        /// PHPTEXCNID.
        /// </summary>
        public const string PHPTEXCNID = "PHPTEXCNID";

        /// <summary>
        /// PHPTPRCNID.
        /// </summary>
        public const string PHPTPRCNID = "PHPTPRCNID";

        /// <summary>
        /// PHPSN.
        /// </summary>
        public const string PHPSN = "PHPSN";

        /// <summary>
        /// PHPTUT01.
        /// </summary>
        public const string PHPTUT01 = "PHPTUT01";

        /// <summary>
        /// PHPTUT02.
        /// </summary>
        public const string PHPTUT02 = "PHPTUT02";

        /// <summary>
        /// PHPTUT03.
        /// </summary>
        public const string PHPTUT03 = "PHPTUT03";

        /// <summary>
        /// PHPTUT04.
        /// </summary>
        public const string PHPTUT04 = "PHPTUT04";

        /// <summary>
        /// PHPTUPUSER.
        /// </summary>
        public const string PHPTUPUSER = "PHPTUPUSER";

        /// <summary>
        /// PHPTUPDTTM.
        /// </summary>
        public const string PHPTUPDTTM = "PHPTUPDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N1601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHCNID", "PHCNID", JdeDataType.String, 40, true, true),
        new JdeField("PHCK", "PHCK", JdeDataType.String, 20),
        new JdeField("PHSTA", "PHSTA", JdeDataType.String, 2),
        new JdeField("PHLOCN", "PHLOCN", JdeDataType.String, 40),
        new JdeField("PHMCU", "PHMCU", JdeDataType.String, 24),
        new JdeField("PHPTCNTP", "PHPTCNTP", JdeDataType.String, 2),
        new JdeField("PHAFWT", "PHAFWT", JdeDataType.Numeric),
        new JdeField("PHBFWT", "PHBFWT", JdeDataType.Numeric),
        new JdeField("PHAWGT", "PHAWGT", JdeDataType.Numeric),
        new JdeField("PHPTEXCNID", "PHPTEXCNID", JdeDataType.String, 40),
        new JdeField("PHPTPRCNID", "PHPTPRCNID", JdeDataType.String, 40),
        new JdeField("PHPSN", "PHPSN", JdeDataType.Numeric),
        new JdeField("PHPTUT01", "PHPTUT01", JdeDataType.String, 100),
        new JdeField("PHPTUT02", "PHPTUT02", JdeDataType.String, 100),
        new JdeField("PHPTUT03", "PHPTUT03", JdeDataType.String, 100),
        new JdeField("PHPTUT04", "PHPTUT04", JdeDataType.String, 100),
        new JdeField("PHPTUPUSER", "PHPTUPUSER", JdeDataType.String, 32),
        new JdeField("PHPTUPDTTM", "PHPTUPDTTM", JdeDataType.String, 28)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N1601_0", "Primary Key on PHCNID", new[] { "PHCNID" }, isUnique: true, isPrimaryKey: true)
    };
}
