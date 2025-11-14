using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B200 - .
/// </summary>
public class F76B200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPBNOP.
        /// </summary>
        public const string DPBNOP = "DPBNOP";

        /// <summary>
        /// DPBSOP.
        /// </summary>
        public const string DPBSOP = "DPBSOP";

        /// <summary>
        /// DPFCO.
        /// </summary>
        public const string DPFCO = "DPFCO";

        /// <summary>
        /// DPSHPJ.
        /// </summary>
        public const string DPSHPJ = "DPSHPJ";

        /// <summary>
        /// DPBRNOP.
        /// </summary>
        public const string DPBRNOP = "DPBRNOP";

        /// <summary>
        /// DPUSER.
        /// </summary>
        public const string DPUSER = "DPUSER";

        /// <summary>
        /// DPPID.
        /// </summary>
        public const string DPPID = "DPPID";

        /// <summary>
        /// DPJOBN.
        /// </summary>
        public const string DPJOBN = "DPJOBN";

        /// <summary>
        /// DPUPMJ.
        /// </summary>
        public const string DPUPMJ = "DPUPMJ";

        /// <summary>
        /// DPUPMT.
        /// </summary>
        public const string DPUPMT = "DPUPMT";

        /// <summary>
        /// DPTDAY.
        /// </summary>
        public const string DPTDAY = "DPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76B200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPBNOP", "DPBNOP", JdeDataType.Numeric, null, true, true),
        new JdeField("DPBSOP", "DPBSOP", JdeDataType.String, 4, true, true),
        new JdeField("DPFCO", "DPFCO", JdeDataType.String, 10, true, true),
        new JdeField("DPSHPJ", "DPSHPJ", JdeDataType.Numeric),
        new JdeField("DPBRNOP", "DPBRNOP", JdeDataType.String, 10),
        new JdeField("DPUSER", "DPUSER", JdeDataType.String, 20),
        new JdeField("DPPID", "DPPID", JdeDataType.String, 20),
        new JdeField("DPJOBN", "DPJOBN", JdeDataType.String, 20),
        new JdeField("DPUPMJ", "DPUPMJ", JdeDataType.Numeric),
        new JdeField("DPUPMT", "DPUPMT", JdeDataType.Numeric),
        new JdeField("DPTDAY", "DPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B200_0", "Primary Key on DPBNOP, DPBSOP, DPFCO", new[] { "DPBNOP", "DPBSOP", "DPFCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B200_2", "Index on DPBRNOP, DPBSOP", new[] { "DPBRNOP", "DPBSOP" })
    };
}
