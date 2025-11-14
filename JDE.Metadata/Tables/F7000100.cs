using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7000100 - .
/// </summary>
public class F7000100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AFLCTR.
        /// </summary>
        public const string AFLCTR = "AFLCTR";

        /// <summary>
        /// AFK70ADSTR.
        /// </summary>
        public const string AFK70ADSTR = "AFK70ADSTR";

        /// <summary>
        /// AFK70ADOBN.
        /// </summary>
        public const string AFK70ADOBN = "AFK70ADOBN";

        /// <summary>
        /// AFK70ADOBR.
        /// </summary>
        public const string AFK70ADOBR = "AFK70ADOBR";

        /// <summary>
        /// AFUSER.
        /// </summary>
        public const string AFUSER = "AFUSER";

        /// <summary>
        /// AFPID.
        /// </summary>
        public const string AFPID = "AFPID";

        /// <summary>
        /// AFJOBN.
        /// </summary>
        public const string AFJOBN = "AFJOBN";

        /// <summary>
        /// AFUPMT.
        /// </summary>
        public const string AFUPMT = "AFUPMT";

        /// <summary>
        /// AFUPMJ.
        /// </summary>
        public const string AFUPMJ = "AFUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F7000100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AFLCTR", "AFLCTR", JdeDataType.String, 6, true, true),
        new JdeField("AFK70ADSTR", "AFK70ADSTR", JdeDataType.String, 20, true, true),
        new JdeField("AFK70ADOBN", "AFK70ADOBN", JdeDataType.String, 20, true, true),
        new JdeField("AFK70ADOBR", "AFK70ADOBR", JdeDataType.String, 20),
        new JdeField("AFUSER", "AFUSER", JdeDataType.String, 20),
        new JdeField("AFPID", "AFPID", JdeDataType.String, 20),
        new JdeField("AFJOBN", "AFJOBN", JdeDataType.String, 20),
        new JdeField("AFUPMT", "AFUPMT", JdeDataType.Numeric),
        new JdeField("AFUPMJ", "AFUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7000100_0", "Primary Key on AFLCTR, AFK70ADSTR, AFK70ADOBN", new[] { "AFLCTR", "AFK70ADSTR", "AFK70ADOBN" }, isUnique: true, isPrimaryKey: true)
    };
}
