using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31UI802 - .
/// </summary>
public class F31UI802 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WGDCT.
        /// </summary>
        public const string WGDCT = "WGDCT";

        /// <summary>
        /// WGANI.
        /// </summary>
        public const string WGANI = "WGANI";

        /// <summary>
        /// WGEV01.
        /// </summary>
        public const string WGEV01 = "WGEV01";

        /// <summary>
        /// WGAA.
        /// </summary>
        public const string WGAA = "WGAA";

        /// <summary>
        /// WGMCU.
        /// </summary>
        public const string WGMCU = "WGMCU";

        /// <summary>
        /// WGOBJ.
        /// </summary>
        public const string WGOBJ = "WGOBJ";

        /// <summary>
        /// WGSUB.
        /// </summary>
        public const string WGSUB = "WGSUB";

        /// <summary>
        /// WGUM.
        /// </summary>
        public const string WGUM = "WGUM";

        /// <summary>
        /// WGAID.
        /// </summary>
        public const string WGAID = "WGAID";

        /// <summary>
        /// WGCO.
        /// </summary>
        public const string WGCO = "WGCO";

        /// <summary>
        /// WGDL01.
        /// </summary>
        public const string WGDL01 = "WGDL01";

        /// <summary>
        /// WGU.
        /// </summary>
        public const string WGU = "WGU";

        /// <summary>
        /// WGJOBS.
        /// </summary>
        public const string WGJOBS = "WGJOBS";

        /// <summary>
        /// WGCTID.
        /// </summary>
        public const string WGCTID = "WGCTID";

        /// <summary>
        /// WGLNID.
        /// </summary>
        public const string WGLNID = "WGLNID";

        /// <summary>
        /// WGDOCO.
        /// </summary>
        public const string WGDOCO = "WGDOCO";

        /// <summary>
        /// WGABT1.
        /// </summary>
        public const string WGABT1 = "WGABT1";

        /// <summary>
        /// WGABR1.
        /// </summary>
        public const string WGABR1 = "WGABR1";

        /// <summary>
        /// WGABT2.
        /// </summary>
        public const string WGABT2 = "WGABT2";

        /// <summary>
        /// WGABR2.
        /// </summary>
        public const string WGABR2 = "WGABR2";

        /// <summary>
        /// WGABT3.
        /// </summary>
        public const string WGABT3 = "WGABT3";

        /// <summary>
        /// WGITM.
        /// </summary>
        public const string WGITM = "WGITM";

        /// <summary>
        /// WGABR3.
        /// </summary>
        public const string WGABR3 = "WGABR3";

        /// <summary>
        /// WGABT4.
        /// </summary>
        public const string WGABT4 = "WGABT4";

        /// <summary>
        /// WGABR4.
        /// </summary>
        public const string WGABR4 = "WGABR4";
    }

    /// <inheritdoc />
    public override string TableName => "F31UI802";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WGDCT", "WGDCT", JdeDataType.String, 4, true, true),
        new JdeField("WGANI", "WGANI", JdeDataType.String, 58),
        new JdeField("WGEV01", "WGEV01", JdeDataType.String, 2, true, true),
        new JdeField("WGAA", "WGAA", JdeDataType.Numeric),
        new JdeField("WGMCU", "WGMCU", JdeDataType.String, 24),
        new JdeField("WGOBJ", "WGOBJ", JdeDataType.String, 12),
        new JdeField("WGSUB", "WGSUB", JdeDataType.String, 16),
        new JdeField("WGUM", "WGUM", JdeDataType.String, 4),
        new JdeField("WGAID", "WGAID", JdeDataType.String, 16, true, true),
        new JdeField("WGCO", "WGCO", JdeDataType.String, 10),
        new JdeField("WGDL01", "WGDL01", JdeDataType.String, 60),
        new JdeField("WGU", "WGU", JdeDataType.Numeric),
        new JdeField("WGJOBS", "WGJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WGCTID", "WGCTID", JdeDataType.String, 30),
        new JdeField("WGLNID", "WGLNID", JdeDataType.Numeric),
        new JdeField("WGDOCO", "WGDOCO", JdeDataType.Numeric),
        new JdeField("WGABT1", "WGABT1", JdeDataType.String, 2, true, true),
        new JdeField("WGABR1", "WGABR1", JdeDataType.String, 24, true, true),
        new JdeField("WGABT2", "WGABT2", JdeDataType.String, 2, true, true),
        new JdeField("WGABR2", "WGABR2", JdeDataType.String, 24, true, true),
        new JdeField("WGABT3", "WGABT3", JdeDataType.String, 2, true, true),
        new JdeField("WGITM", "WGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WGABR3", "WGABR3", JdeDataType.String, 24, true, true),
        new JdeField("WGABT4", "WGABT4", JdeDataType.String, 2, true, true),
        new JdeField("WGABR4", "WGABR4", JdeDataType.String, 24, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31UI802_0", "Primary Key on WGDCT, WGAID, WGEV01, WGJOBS, WGABT1, WGABR1, WGABT2, WGABR2, WGABT3, WGABR3, WGABT4, WGABR4, WGITM", new[] { "WGDCT", "WGAID", "WGEV01", "WGJOBS", "WGABT1", "WGABR1", "WGABT2", "WGABR2", "WGABT3", "WGABR3", "WGABT4", "WGABR4", "WGITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31UI802_2", "Index on WGJOBS", new[] { "WGJOBS" }),
        new JdeIndex("F31UI802_3", "Index on WGDOCO", new[] { "WGDOCO" })
    };
}
