using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085540 - .
/// </summary>
public class F085540 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PUPLAN.
        /// </summary>
        public const string PUPLAN = "PUPLAN";

        /// <summary>
        /// PUAOPT.
        /// </summary>
        public const string PUAOPT = "PUAOPT";

        /// <summary>
        /// PUSBGR.
        /// </summary>
        public const string PUSBGR = "PUSBGR";

        /// <summary>
        /// PUDIVC.
        /// </summary>
        public const string PUDIVC = "PUDIVC";

        /// <summary>
        /// PULNGP.
        /// </summary>
        public const string PULNGP = "PULNGP";

        /// <summary>
        /// PUCCPR.
        /// </summary>
        public const string PUCCPR = "PUCCPR";

        /// <summary>
        /// PUURLT.
        /// </summary>
        public const string PUURLT = "PUURLT";

        /// <summary>
        /// PUCO.
        /// </summary>
        public const string PUCO = "PUCO";

        /// <summary>
        /// PUPTURL.
        /// </summary>
        public const string PUPTURL = "PUPTURL";

        /// <summary>
        /// PUUSER.
        /// </summary>
        public const string PUUSER = "PUUSER";

        /// <summary>
        /// PUPID.
        /// </summary>
        public const string PUPID = "PUPID";

        /// <summary>
        /// PUJOBN.
        /// </summary>
        public const string PUJOBN = "PUJOBN";

        /// <summary>
        /// PUUPMJ.
        /// </summary>
        public const string PUUPMJ = "PUUPMJ";

        /// <summary>
        /// PUUPMT.
        /// </summary>
        public const string PUUPMT = "PUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F085540";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PUPLAN", "PUPLAN", JdeDataType.String, 16, true, true),
        new JdeField("PUAOPT", "PUAOPT", JdeDataType.String, 6, true, true),
        new JdeField("PUSBGR", "PUSBGR", JdeDataType.String, 20, true, true),
        new JdeField("PUDIVC", "PUDIVC", JdeDataType.String, 12, true, true),
        new JdeField("PULNGP", "PULNGP", JdeDataType.String, 4, true, true),
        new JdeField("PUCCPR", "PUCCPR", JdeDataType.String, 6, true, true),
        new JdeField("PUURLT", "PUURLT", JdeDataType.String, 6, true, true),
        new JdeField("PUCO", "PUCO", JdeDataType.String, 10, true, true),
        new JdeField("PUPTURL", "PUPTURL", JdeDataType.String, 512),
        new JdeField("PUUSER", "PUUSER", JdeDataType.String, 20),
        new JdeField("PUPID", "PUPID", JdeDataType.String, 20),
        new JdeField("PUJOBN", "PUJOBN", JdeDataType.String, 20),
        new JdeField("PUUPMJ", "PUUPMJ", JdeDataType.Numeric),
        new JdeField("PUUPMT", "PUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085540_0", "Primary Key on PUPLAN, PUAOPT, PUSBGR, PUDIVC, PULNGP, PUCCPR, PUCO, PUURLT", new[] { "PUPLAN", "PUAOPT", "PUSBGR", "PUDIVC", "PULNGP", "PUCCPR", "PUCO", "PUURLT" }, isUnique: true, isPrimaryKey: true)
    };
}
