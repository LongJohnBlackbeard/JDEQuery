using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09706W - .
/// </summary>
public class F09706W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NBUSER.
        /// </summary>
        public const string NBUSER = "NBUSER";

        /// <summary>
        /// NBUKID.
        /// </summary>
        public const string NBUKID = "NBUKID";

        /// <summary>
        /// NBICU.
        /// </summary>
        public const string NBICU = "NBICU";

        /// <summary>
        /// NBICUT.
        /// </summary>
        public const string NBICUT = "NBICUT";

        /// <summary>
        /// NBLT.
        /// </summary>
        public const string NBLT = "NBLT";

        /// <summary>
        /// NBCO.
        /// </summary>
        public const string NBCO = "NBCO";

        /// <summary>
        /// NBDICJ.
        /// </summary>
        public const string NBDICJ = "NBDICJ";

        /// <summary>
        /// NBAA.
        /// </summary>
        public const string NBAA = "NBAA";
    }

    /// <inheritdoc />
    public override string TableName => "F09706W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NBUSER", "NBUSER", JdeDataType.String, 20, true, true),
        new JdeField("NBUKID", "NBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("NBICU", "NBICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NBICUT", "NBICUT", JdeDataType.String, 4, true, true),
        new JdeField("NBLT", "NBLT", JdeDataType.String, 4, true, true),
        new JdeField("NBCO", "NBCO", JdeDataType.String, 10, true, true),
        new JdeField("NBDICJ", "NBDICJ", JdeDataType.Numeric, null, true, true),
        new JdeField("NBAA", "NBAA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09706W_0", "Primary Key on NBUSER, NBUKID, NBICU, NBICUT, NBLT, NBCO, NBDICJ", new[] { "NBUSER", "NBUKID", "NBICU", "NBICUT", "NBLT", "NBCO", "NBDICJ" }, isUnique: true, isPrimaryKey: true)
    };
}
