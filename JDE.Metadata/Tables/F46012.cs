using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46012 - .
/// </summary>
public class F46012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISTYFL.
        /// </summary>
        public const string ISTYFL = "ISTYFL";

        /// <summary>
        /// ISMCU.
        /// </summary>
        public const string ISMCU = "ISMCU";

        /// <summary>
        /// ISITM.
        /// </summary>
        public const string ISITM = "ISITM";

        /// <summary>
        /// ISUOM.
        /// </summary>
        public const string ISUOM = "ISUOM";

        /// <summary>
        /// ISLOCN.
        /// </summary>
        public const string ISLOCN = "ISLOCN";

        /// <summary>
        /// ISLETC.
        /// </summary>
        public const string ISLETC = "ISLETC";

        /// <summary>
        /// ISLETP.
        /// </summary>
        public const string ISLETP = "ISLETP";

        /// <summary>
        /// ISMXRP.
        /// </summary>
        public const string ISMXRP = "ISMXRP";

        /// <summary>
        /// ISMXOV.
        /// </summary>
        public const string ISMXOV = "ISMXOV";

        /// <summary>
        /// ISMXPK.
        /// </summary>
        public const string ISMXPK = "ISMXPK";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISTDAY.
        /// </summary>
        public const string ISTDAY = "ISTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISTYFL", "ISTYFL", JdeDataType.String, 2, true, true),
        new JdeField("ISMCU", "ISMCU", JdeDataType.String, 24, true, true),
        new JdeField("ISITM", "ISITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ISUOM", "ISUOM", JdeDataType.String, 4, true, true),
        new JdeField("ISLOCN", "ISLOCN", JdeDataType.String, 40, true, true),
        new JdeField("ISLETC", "ISLETC", JdeDataType.Numeric),
        new JdeField("ISLETP", "ISLETP", JdeDataType.Numeric),
        new JdeField("ISMXRP", "ISMXRP", JdeDataType.Numeric),
        new JdeField("ISMXOV", "ISMXOV", JdeDataType.Numeric),
        new JdeField("ISMXPK", "ISMXPK", JdeDataType.Numeric),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISTDAY", "ISTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46012_0", "Primary Key on ISTYFL, ISMCU, ISITM, ISUOM, ISLOCN", new[] { "ISTYFL", "ISMCU", "ISITM", "ISUOM", "ISLOCN" }, isUnique: true, isPrimaryKey: true)
    };
}
