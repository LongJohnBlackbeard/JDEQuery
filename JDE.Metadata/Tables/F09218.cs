using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09218 - .
/// </summary>
public class F09218 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LSCO.
        /// </summary>
        public const string LSCO = "LSCO";

        /// <summary>
        /// LSCDAA.
        /// </summary>
        public const string LSCDAA = "LSCDAA";

        /// <summary>
        /// LSCDAV.
        /// </summary>
        public const string LSCDAV = "LSCDAV";

        /// <summary>
        /// LSCDBB.
        /// </summary>
        public const string LSCDBB = "LSCDBB";

        /// <summary>
        /// LSCDBV.
        /// </summary>
        public const string LSCDBV = "LSCDBV";

        /// <summary>
        /// LSCDCC.
        /// </summary>
        public const string LSCDCC = "LSCDCC";

        /// <summary>
        /// LSCDCV.
        /// </summary>
        public const string LSCDCV = "LSCDCV";

        /// <summary>
        /// LSCDDD.
        /// </summary>
        public const string LSCDDD = "LSCDDD";

        /// <summary>
        /// LSCDDV.
        /// </summary>
        public const string LSCDDV = "LSCDDV";

        /// <summary>
        /// LSOTPS.
        /// </summary>
        public const string LSOTPS = "LSOTPS";

        /// <summary>
        /// LSMCU1.
        /// </summary>
        public const string LSMCU1 = "LSMCU1";

        /// <summary>
        /// LSMCUM.
        /// </summary>
        public const string LSMCUM = "LSMCUM";

        /// <summary>
        /// LSIDXN.
        /// </summary>
        public const string LSIDXN = "LSIDXN";

        /// <summary>
        /// LSDL10.
        /// </summary>
        public const string LSDL10 = "LSDL10";

        /// <summary>
        /// LSDGJ.
        /// </summary>
        public const string LSDGJ = "LSDGJ";

        /// <summary>
        /// LSN001.
        /// </summary>
        public const string LSN001 = "LSN001";
    }

    /// <inheritdoc />
    public override string TableName => "F09218";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LSCO", "LSCO", JdeDataType.String, 10),
        new JdeField("LSCDAA", "LSCDAA", JdeDataType.String, 4),
        new JdeField("LSCDAV", "LSCDAV", JdeDataType.String, 20),
        new JdeField("LSCDBB", "LSCDBB", JdeDataType.String, 4),
        new JdeField("LSCDBV", "LSCDBV", JdeDataType.String, 20),
        new JdeField("LSCDCC", "LSCDCC", JdeDataType.String, 4),
        new JdeField("LSCDCV", "LSCDCV", JdeDataType.String, 20),
        new JdeField("LSCDDD", "LSCDDD", JdeDataType.String, 4),
        new JdeField("LSCDDV", "LSCDDV", JdeDataType.String, 20),
        new JdeField("LSOTPS", "LSOTPS", JdeDataType.String, 6),
        new JdeField("LSMCU1", "LSMCU1", JdeDataType.String, 24),
        new JdeField("LSMCUM", "LSMCUM", JdeDataType.String, 24),
        new JdeField("LSIDXN", "LSIDXN", JdeDataType.String, 20, true, true),
        new JdeField("LSDL10", "LSDL10", JdeDataType.String, 60),
        new JdeField("LSDGJ", "LSDGJ", JdeDataType.Numeric),
        new JdeField("LSN001", "LSN001", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09218_0", "Primary Key on LSIDXN", new[] { "LSIDXN" }, isUnique: true, isPrimaryKey: true)
    };
}
