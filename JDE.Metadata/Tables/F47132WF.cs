using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47132WF - .
/// </summary>
public class F47132WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWUKID.
        /// </summary>
        public const string SWUKID = "SWUKID";

        /// <summary>
        /// SWDOCO.
        /// </summary>
        public const string SWDOCO = "SWDOCO";

        /// <summary>
        /// SWDCTO.
        /// </summary>
        public const string SWDCTO = "SWDCTO";

        /// <summary>
        /// SWKCOO.
        /// </summary>
        public const string SWKCOO = "SWKCOO";

        /// <summary>
        /// SWLNID.
        /// </summary>
        public const string SWLNID = "SWLNID";

        /// <summary>
        /// SWADDJ.
        /// </summary>
        public const string SWADDJ = "SWADDJ";

        /// <summary>
        /// SWADTM.
        /// </summary>
        public const string SWADTM = "SWADTM";

        /// <summary>
        /// SWDCT.
        /// </summary>
        public const string SWDCT = "SWDCT";

        /// <summary>
        /// SWKCO.
        /// </summary>
        public const string SWKCO = "SWKCO";

        /// <summary>
        /// SWNXTR.
        /// </summary>
        public const string SWNXTR = "SWNXTR";

        /// <summary>
        /// SWPVEH.
        /// </summary>
        public const string SWPVEH = "SWPVEH";

        /// <summary>
        /// SWPRLO.
        /// </summary>
        public const string SWPRLO = "SWPRLO";

        /// <summary>
        /// SWLDDT.
        /// </summary>
        public const string SWLDDT = "SWLDDT";

        /// <summary>
        /// SWLDTM.
        /// </summary>
        public const string SWLDTM = "SWLDTM";

        /// <summary>
        /// SWVMCU.
        /// </summary>
        public const string SWVMCU = "SWVMCU";

        /// <summary>
        /// SWLDNM.
        /// </summary>
        public const string SWLDNM = "SWLDNM";

        /// <summary>
        /// SWLNMB.
        /// </summary>
        public const string SWLNMB = "SWLNMB";

        /// <summary>
        /// SWVTYP.
        /// </summary>
        public const string SWVTYP = "SWVTYP";

        /// <summary>
        /// SWCNNV.
        /// </summary>
        public const string SWCNNV = "SWCNNV";

        /// <summary>
        /// SWCARS.
        /// </summary>
        public const string SWCARS = "SWCARS";

        /// <summary>
        /// SWMOT.
        /// </summary>
        public const string SWMOT = "SWMOT";

        /// <summary>
        /// SWIAFL.
        /// </summary>
        public const string SWIAFL = "SWIAFL";
    }

    /// <inheritdoc />
    public override string TableName => "F47132WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWUKID", "SWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SWDOCO", "SWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SWDCTO", "SWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SWKCOO", "SWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SWLNID", "SWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SWADDJ", "SWADDJ", JdeDataType.Numeric),
        new JdeField("SWADTM", "SWADTM", JdeDataType.Numeric),
        new JdeField("SWDCT", "SWDCT", JdeDataType.String, 4),
        new JdeField("SWKCO", "SWKCO", JdeDataType.String, 10),
        new JdeField("SWNXTR", "SWNXTR", JdeDataType.String, 6),
        new JdeField("SWPVEH", "SWPVEH", JdeDataType.String, 24),
        new JdeField("SWPRLO", "SWPRLO", JdeDataType.String, 26),
        new JdeField("SWLDDT", "SWLDDT", JdeDataType.Numeric),
        new JdeField("SWLDTM", "SWLDTM", JdeDataType.Numeric),
        new JdeField("SWVMCU", "SWVMCU", JdeDataType.String, 24),
        new JdeField("SWLDNM", "SWLDNM", JdeDataType.Numeric),
        new JdeField("SWLNMB", "SWLNMB", JdeDataType.Numeric),
        new JdeField("SWVTYP", "SWVTYP", JdeDataType.String, 24),
        new JdeField("SWCNNV", "SWCNNV", JdeDataType.String, 2),
        new JdeField("SWCARS", "SWCARS", JdeDataType.Numeric),
        new JdeField("SWMOT", "SWMOT", JdeDataType.String, 6),
        new JdeField("SWIAFL", "SWIAFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47132WF_0", "Primary Key on SWUKID, SWDOCO, SWDCTO, SWKCOO, SWLNID", new[] { "SWUKID", "SWDOCO", "SWDCTO", "SWKCOO", "SWLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
