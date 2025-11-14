using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700050 - .
/// </summary>
public class F700050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCCRCD.
        /// </summary>
        public const string BCCRCD = "BCCRCD";

        /// <summary>
        /// BCCO.
        /// </summary>
        public const string BCCO = "BCCO";

        /// <summary>
        /// BCMCU.
        /// </summary>
        public const string BCMCU = "BCMCU";

        /// <summary>
        /// BCAN8.
        /// </summary>
        public const string BCAN8 = "BCAN8";

        /// <summary>
        /// BCUKID.
        /// </summary>
        public const string BCUKID = "BCUKID";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCUPMT.
        /// </summary>
        public const string BCUPMT = "BCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F700050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCCRCD", "BCCRCD", JdeDataType.String, 6, true, true),
        new JdeField("BCCO", "BCCO", JdeDataType.String, 10, true, true),
        new JdeField("BCMCU", "BCMCU", JdeDataType.String, 24, true, true),
        new JdeField("BCAN8", "BCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BCUKID", "BCUKID", JdeDataType.Numeric),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCUPMT", "BCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700050_0", "Primary Key on BCCRCD, BCCO, BCMCU, BCAN8", new[] { "BCCRCD", "BCCO", "BCMCU", "BCAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
