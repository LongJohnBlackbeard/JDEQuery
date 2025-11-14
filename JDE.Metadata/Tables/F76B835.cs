using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B835 - .
/// </summary>
public class F76B835 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AOICU.
        /// </summary>
        public const string AOICU = "AOICU";

        /// <summary>
        /// AOICUT.
        /// </summary>
        public const string AOICUT = "AOICUT";

        /// <summary>
        /// AODGJ.
        /// </summary>
        public const string AODGJ = "AODGJ";

        /// <summary>
        /// AODOC.
        /// </summary>
        public const string AODOC = "AODOC";

        /// <summary>
        /// AOKCO.
        /// </summary>
        public const string AOKCO = "AOKCO";

        /// <summary>
        /// AOLT.
        /// </summary>
        public const string AOLT = "AOLT";

        /// <summary>
        /// AODCT.
        /// </summary>
        public const string AODCT = "AODCT";

        /// <summary>
        /// AOB76FCAO.
        /// </summary>
        public const string AOB76FCAO = "AOB76FCAO";

        /// <summary>
        /// AOUSER.
        /// </summary>
        public const string AOUSER = "AOUSER";

        /// <summary>
        /// AOPID.
        /// </summary>
        public const string AOPID = "AOPID";

        /// <summary>
        /// AOJOBN.
        /// </summary>
        public const string AOJOBN = "AOJOBN";

        /// <summary>
        /// AOUPMJ.
        /// </summary>
        public const string AOUPMJ = "AOUPMJ";

        /// <summary>
        /// AOUPMT.
        /// </summary>
        public const string AOUPMT = "AOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B835";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AOICU", "AOICU", JdeDataType.Numeric, null, true, true),
        new JdeField("AOICUT", "AOICUT", JdeDataType.String, 4, true, true),
        new JdeField("AODGJ", "AODGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("AODOC", "AODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AOKCO", "AOKCO", JdeDataType.String, 10, true, true),
        new JdeField("AOLT", "AOLT", JdeDataType.String, 4, true, true),
        new JdeField("AODCT", "AODCT", JdeDataType.String, 4, true, true),
        new JdeField("AOB76FCAO", "AOB76FCAO", JdeDataType.String, 20),
        new JdeField("AOUSER", "AOUSER", JdeDataType.String, 20),
        new JdeField("AOPID", "AOPID", JdeDataType.String, 20),
        new JdeField("AOJOBN", "AOJOBN", JdeDataType.String, 20),
        new JdeField("AOUPMJ", "AOUPMJ", JdeDataType.Numeric),
        new JdeField("AOUPMT", "AOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B835_0", "Primary Key on AOICU, AOICUT, AODGJ, AODOC, AOKCO, AOLT, AODCT", new[] { "AOICU", "AOICUT", "AODGJ", "AODOC", "AOKCO", "AOLT", "AODCT" }, isUnique: true, isPrimaryKey: true)
    };
}
