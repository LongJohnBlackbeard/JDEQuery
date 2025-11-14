using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0811639 - .
/// </summary>
public class F0811639 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ASAN8.
        /// </summary>
        public const string ASAN8 = "ASAN8";

        /// <summary>
        /// ASACAD.
        /// </summary>
        public const string ASACAD = "ASACAD";

        /// <summary>
        /// ASACA#.
        /// </summary>
        public const string ASACA_ = "ASACA#";

        /// <summary>
        /// ASHMCO.
        /// </summary>
        public const string ASHMCO = "ASHMCO";

        /// <summary>
        /// ASACTH.
        /// </summary>
        public const string ASACTH = "ASACTH";

        /// <summary>
        /// ASSPADUSE1.
        /// </summary>
        public const string ASSPADUSE1 = "ASSPADUSE1";

        /// <summary>
        /// ASSPADUSE2.
        /// </summary>
        public const string ASSPADUSE2 = "ASSPADUSE2";

        /// <summary>
        /// ASSPASUSE1.
        /// </summary>
        public const string ASSPASUSE1 = "ASSPASUSE1";

        /// <summary>
        /// ASSPASUSE2.
        /// </summary>
        public const string ASSPASUSE2 = "ASSPASUSE2";

        /// <summary>
        /// ASSPANUSE1.
        /// </summary>
        public const string ASSPANUSE1 = "ASSPANUSE1";

        /// <summary>
        /// ASSPANUSE2.
        /// </summary>
        public const string ASSPANUSE2 = "ASSPANUSE2";

        /// <summary>
        /// ASSPACUSE1.
        /// </summary>
        public const string ASSPACUSE1 = "ASSPACUSE1";

        /// <summary>
        /// ASSPACUSE2.
        /// </summary>
        public const string ASSPACUSE2 = "ASSPACUSE2";

        /// <summary>
        /// ASUSER.
        /// </summary>
        public const string ASUSER = "ASUSER";

        /// <summary>
        /// ASPID.
        /// </summary>
        public const string ASPID = "ASPID";

        /// <summary>
        /// ASJOBN.
        /// </summary>
        public const string ASJOBN = "ASJOBN";

        /// <summary>
        /// ASUPMJ.
        /// </summary>
        public const string ASUPMJ = "ASUPMJ";

        /// <summary>
        /// ASUPMT.
        /// </summary>
        public const string ASUPMT = "ASUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0811639";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ASAN8", "ASAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ASACAD", "ASACAD", JdeDataType.String, 20, true, true),
        new JdeField("ASACA#", "ASACA#", JdeDataType.Numeric, null, true, true),
        new JdeField("ASHMCO", "ASHMCO", JdeDataType.String, 10, true, true),
        new JdeField("ASACTH", "ASACTH", JdeDataType.Numeric),
        new JdeField("ASSPADUSE1", "ASSPADUSE1", JdeDataType.Numeric),
        new JdeField("ASSPADUSE2", "ASSPADUSE2", JdeDataType.Numeric),
        new JdeField("ASSPASUSE1", "ASSPASUSE1", JdeDataType.String, 60),
        new JdeField("ASSPASUSE2", "ASSPASUSE2", JdeDataType.String, 60),
        new JdeField("ASSPANUSE1", "ASSPANUSE1", JdeDataType.Numeric),
        new JdeField("ASSPANUSE2", "ASSPANUSE2", JdeDataType.Numeric),
        new JdeField("ASSPACUSE1", "ASSPACUSE1", JdeDataType.String, 2),
        new JdeField("ASSPACUSE2", "ASSPACUSE2", JdeDataType.String, 2),
        new JdeField("ASUSER", "ASUSER", JdeDataType.String, 20),
        new JdeField("ASPID", "ASPID", JdeDataType.String, 20),
        new JdeField("ASJOBN", "ASJOBN", JdeDataType.String, 20),
        new JdeField("ASUPMJ", "ASUPMJ", JdeDataType.Numeric),
        new JdeField("ASUPMT", "ASUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0811639_0", "Primary Key on ASAN8, ASACAD, ASACA#, ASHMCO", new[] { "ASAN8", "ASACAD", "ASACA#", "ASHMCO" }, isUnique: true, isPrimaryKey: true)
    };
}
