using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0806 - .
/// </summary>
public class F76B0806 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MIB76ATCT.
        /// </summary>
        public const string MIB76ATCT = "MIB76ATCT";

        /// <summary>
        /// MIJOBS.
        /// </summary>
        public const string MIJOBS = "MIJOBS";

        /// <summary>
        /// MIB76BLCK.
        /// </summary>
        public const string MIB76BLCK = "MIB76BLCK";

        /// <summary>
        /// MIKY.
        /// </summary>
        public const string MIKY = "MIKY";

        /// <summary>
        /// MIDL01.
        /// </summary>
        public const string MIDL01 = "MIDL01";

        /// <summary>
        /// MIDL02.
        /// </summary>
        public const string MIDL02 = "MIDL02";

        /// <summary>
        /// MIB76URAB.
        /// </summary>
        public const string MIB76URAB = "MIB76URAB";

        /// <summary>
        /// MIB76URAT.
        /// </summary>
        public const string MIB76URAT = "MIB76URAT";

        /// <summary>
        /// MIB76URRF.
        /// </summary>
        public const string MIB76URRF = "MIB76URRF";

        /// <summary>
        /// MIB76URDT.
        /// </summary>
        public const string MIB76URDT = "MIB76URDT";

        /// <summary>
        /// MIB76URCD.
        /// </summary>
        public const string MIB76URCD = "MIB76URCD";

        /// <summary>
        /// MIUSER.
        /// </summary>
        public const string MIUSER = "MIUSER";

        /// <summary>
        /// MIPID.
        /// </summary>
        public const string MIPID = "MIPID";

        /// <summary>
        /// MIJOBN.
        /// </summary>
        public const string MIJOBN = "MIJOBN";

        /// <summary>
        /// MIUPMJ.
        /// </summary>
        public const string MIUPMJ = "MIUPMJ";

        /// <summary>
        /// MIUPMT.
        /// </summary>
        public const string MIUPMT = "MIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0806";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MIB76ATCT", "MIB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("MIJOBS", "MIJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("MIB76BLCK", "MIB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("MIKY", "MIKY", JdeDataType.String, 20, true, true),
        new JdeField("MIDL01", "MIDL01", JdeDataType.String, 60),
        new JdeField("MIDL02", "MIDL02", JdeDataType.String, 60),
        new JdeField("MIB76URAB", "MIB76URAB", JdeDataType.Numeric),
        new JdeField("MIB76URAT", "MIB76URAT", JdeDataType.Numeric),
        new JdeField("MIB76URRF", "MIB76URRF", JdeDataType.String, 30),
        new JdeField("MIB76URDT", "MIB76URDT", JdeDataType.Numeric),
        new JdeField("MIB76URCD", "MIB76URCD", JdeDataType.String, 4),
        new JdeField("MIUSER", "MIUSER", JdeDataType.String, 20),
        new JdeField("MIPID", "MIPID", JdeDataType.String, 20),
        new JdeField("MIJOBN", "MIJOBN", JdeDataType.String, 20),
        new JdeField("MIUPMJ", "MIUPMJ", JdeDataType.Numeric),
        new JdeField("MIUPMT", "MIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0806_0", "Primary Key on MIB76ATCT, MIJOBS, MIB76BLCK, MIKY", new[] { "MIB76ATCT", "MIJOBS", "MIB76BLCK", "MIKY" }, isUnique: true, isPrimaryKey: true)
    };
}
