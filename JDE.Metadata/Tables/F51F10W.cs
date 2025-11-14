using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F10W - .
/// </summary>
public class F51F10W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PB51FFID.
        /// </summary>
        public const string PB51FFID = "PB51FFID";

        /// <summary>
        /// PBAID.
        /// </summary>
        public const string PBAID = "PBAID";

        /// <summary>
        /// PB51FFAMT.
        /// </summary>
        public const string PB51FFAMT = "PB51FFAMT";

        /// <summary>
        /// PB51FFAMTA.
        /// </summary>
        public const string PB51FFAMTA = "PB51FFAMTA";

        /// <summary>
        /// PBMCU.
        /// </summary>
        public const string PBMCU = "PBMCU";

        /// <summary>
        /// PBOBJ.
        /// </summary>
        public const string PBOBJ = "PBOBJ";

        /// <summary>
        /// PBSUB.
        /// </summary>
        public const string PBSUB = "PBSUB";

        /// <summary>
        /// PB51FBLTOT.
        /// </summary>
        public const string PB51FBLTOT = "PB51FBLTOT";

        /// <summary>
        /// PB51FBLNET.
        /// </summary>
        public const string PB51FBLNET = "PB51FBLNET";

        /// <summary>
        /// PB51FBLTAX.
        /// </summary>
        public const string PB51FBLTAX = "PB51FBLTAX";

        /// <summary>
        /// PB51FUNTOT.
        /// </summary>
        public const string PB51FUNTOT = "PB51FUNTOT";

        /// <summary>
        /// PB51FUNNET.
        /// </summary>
        public const string PB51FUNNET = "PB51FUNNET";

        /// <summary>
        /// PB51FUNTAX.
        /// </summary>
        public const string PB51FUNTAX = "PB51FUNTAX";

        /// <summary>
        /// PB51FRECD.
        /// </summary>
        public const string PB51FRECD = "PB51FRECD";

        /// <summary>
        /// PB51FRETN.
        /// </summary>
        public const string PB51FRETN = "PB51FRETN";

        /// <summary>
        /// PB51FTOTA1.
        /// </summary>
        public const string PB51FTOTA1 = "PB51FTOTA1";

        /// <summary>
        /// PB51FTOTU1.
        /// </summary>
        public const string PB51FTOTU1 = "PB51FTOTU1";

        /// <summary>
        /// PB51FCTCR.
        /// </summary>
        public const string PB51FCTCR = "PB51FCTCR";

        /// <summary>
        /// PB51FTWU.
        /// </summary>
        public const string PB51FTWU = "PB51FTWU";

        /// <summary>
        /// PBUKID.
        /// </summary>
        public const string PBUKID = "PBUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F51F10W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PB51FFID", "PB51FFID", JdeDataType.Numeric, null, true, true),
        new JdeField("PBAID", "PBAID", JdeDataType.String, 16, true, true),
        new JdeField("PB51FFAMT", "PB51FFAMT", JdeDataType.String, 2, true, true),
        new JdeField("PB51FFAMTA", "PB51FFAMTA", JdeDataType.String, 2, true, true),
        new JdeField("PBMCU", "PBMCU", JdeDataType.String, 24),
        new JdeField("PBOBJ", "PBOBJ", JdeDataType.String, 12),
        new JdeField("PBSUB", "PBSUB", JdeDataType.String, 16),
        new JdeField("PB51FBLTOT", "PB51FBLTOT", JdeDataType.Numeric),
        new JdeField("PB51FBLNET", "PB51FBLNET", JdeDataType.Numeric),
        new JdeField("PB51FBLTAX", "PB51FBLTAX", JdeDataType.Numeric),
        new JdeField("PB51FUNTOT", "PB51FUNTOT", JdeDataType.Numeric),
        new JdeField("PB51FUNNET", "PB51FUNNET", JdeDataType.Numeric),
        new JdeField("PB51FUNTAX", "PB51FUNTAX", JdeDataType.Numeric),
        new JdeField("PB51FRECD", "PB51FRECD", JdeDataType.Numeric),
        new JdeField("PB51FRETN", "PB51FRETN", JdeDataType.Numeric),
        new JdeField("PB51FTOTA1", "PB51FTOTA1", JdeDataType.Numeric),
        new JdeField("PB51FTOTU1", "PB51FTOTU1", JdeDataType.Numeric),
        new JdeField("PB51FCTCR", "PB51FCTCR", JdeDataType.Numeric),
        new JdeField("PB51FTWU", "PB51FTWU", JdeDataType.Numeric),
        new JdeField("PBUKID", "PBUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F10W_0", "Primary Key on PBUKID, PB51FFID, PBAID, PB51FFAMT, PB51FFAMTA", new[] { "PBUKID", "PB51FFID", "PBAID", "PB51FFAMT", "PB51FFAMTA" }, isUnique: true, isPrimaryKey: true)
    };
}
