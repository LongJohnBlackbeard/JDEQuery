using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31UI803 - .
/// </summary>
public class F31UI803 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SGDCT.
        /// </summary>
        public const string SGDCT = "SGDCT";

        /// <summary>
        /// SGANI.
        /// </summary>
        public const string SGANI = "SGANI";

        /// <summary>
        /// SGEV01.
        /// </summary>
        public const string SGEV01 = "SGEV01";

        /// <summary>
        /// SGAA.
        /// </summary>
        public const string SGAA = "SGAA";

        /// <summary>
        /// SGMCU.
        /// </summary>
        public const string SGMCU = "SGMCU";

        /// <summary>
        /// SGOBJ.
        /// </summary>
        public const string SGOBJ = "SGOBJ";

        /// <summary>
        /// SGSUB.
        /// </summary>
        public const string SGSUB = "SGSUB";

        /// <summary>
        /// SGUM.
        /// </summary>
        public const string SGUM = "SGUM";

        /// <summary>
        /// SGAID.
        /// </summary>
        public const string SGAID = "SGAID";

        /// <summary>
        /// SGCO.
        /// </summary>
        public const string SGCO = "SGCO";

        /// <summary>
        /// SGDL01.
        /// </summary>
        public const string SGDL01 = "SGDL01";

        /// <summary>
        /// SGU.
        /// </summary>
        public const string SGU = "SGU";

        /// <summary>
        /// SGJOBS.
        /// </summary>
        public const string SGJOBS = "SGJOBS";

        /// <summary>
        /// SGCTID.
        /// </summary>
        public const string SGCTID = "SGCTID";

        /// <summary>
        /// SGLNID.
        /// </summary>
        public const string SGLNID = "SGLNID";

        /// <summary>
        /// SGDOCO.
        /// </summary>
        public const string SGDOCO = "SGDOCO";

        /// <summary>
        /// SGABT1.
        /// </summary>
        public const string SGABT1 = "SGABT1";

        /// <summary>
        /// SGABR1.
        /// </summary>
        public const string SGABR1 = "SGABR1";

        /// <summary>
        /// SGABT2.
        /// </summary>
        public const string SGABT2 = "SGABT2";

        /// <summary>
        /// SGABR2.
        /// </summary>
        public const string SGABR2 = "SGABR2";

        /// <summary>
        /// SGABT3.
        /// </summary>
        public const string SGABT3 = "SGABT3";

        /// <summary>
        /// SGABR3.
        /// </summary>
        public const string SGABR3 = "SGABR3";

        /// <summary>
        /// SGABT4.
        /// </summary>
        public const string SGABT4 = "SGABT4";

        /// <summary>
        /// SGABR4.
        /// </summary>
        public const string SGABR4 = "SGABR4";

        /// <summary>
        /// SGITM.
        /// </summary>
        public const string SGITM = "SGITM";

        /// <summary>
        /// SGUSER.
        /// </summary>
        public const string SGUSER = "SGUSER";

        /// <summary>
        /// SGPEID.
        /// </summary>
        public const string SGPEID = "SGPEID";
    }

    /// <inheritdoc />
    public override string TableName => "F31UI803";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SGDCT", "SGDCT", JdeDataType.String, 4, true, true),
        new JdeField("SGANI", "SGANI", JdeDataType.String, 58),
        new JdeField("SGEV01", "SGEV01", JdeDataType.String, 2, true, true),
        new JdeField("SGAA", "SGAA", JdeDataType.Numeric),
        new JdeField("SGMCU", "SGMCU", JdeDataType.String, 24),
        new JdeField("SGOBJ", "SGOBJ", JdeDataType.String, 12),
        new JdeField("SGSUB", "SGSUB", JdeDataType.String, 16),
        new JdeField("SGUM", "SGUM", JdeDataType.String, 4),
        new JdeField("SGAID", "SGAID", JdeDataType.String, 16, true, true),
        new JdeField("SGCO", "SGCO", JdeDataType.String, 10),
        new JdeField("SGDL01", "SGDL01", JdeDataType.String, 60),
        new JdeField("SGU", "SGU", JdeDataType.Numeric),
        new JdeField("SGJOBS", "SGJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SGCTID", "SGCTID", JdeDataType.String, 30),
        new JdeField("SGLNID", "SGLNID", JdeDataType.Numeric),
        new JdeField("SGDOCO", "SGDOCO", JdeDataType.Numeric),
        new JdeField("SGABT1", "SGABT1", JdeDataType.String, 2, true, true),
        new JdeField("SGABR1", "SGABR1", JdeDataType.String, 24, true, true),
        new JdeField("SGABT2", "SGABT2", JdeDataType.String, 2, true, true),
        new JdeField("SGABR2", "SGABR2", JdeDataType.String, 24, true, true),
        new JdeField("SGABT3", "SGABT3", JdeDataType.String, 2, true, true),
        new JdeField("SGABR3", "SGABR3", JdeDataType.String, 24, true, true),
        new JdeField("SGABT4", "SGABT4", JdeDataType.String, 2, true, true),
        new JdeField("SGABR4", "SGABR4", JdeDataType.String, 24, true, true),
        new JdeField("SGITM", "SGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SGUSER", "SGUSER", JdeDataType.String, 20, true, true),
        new JdeField("SGPEID", "SGPEID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31UI803_0", "Primary Key on SGDCT, SGEV01, SGAID, SGJOBS, SGABT1, SGABR1, SGABT2, SGABR2, SGABT3, SGABR3, SGABT4, SGABR4, SGITM, SGUSER, SGPEID", new[] { "SGDCT", "SGEV01", "SGAID", "SGJOBS", "SGABT1", "SGABR1", "SGABT2", "SGABR2", "SGABT3", "SGABR3", "SGABT4", "SGABR4", "SGITM", "SGUSER", "SGPEID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31UI803_3", "Index on SGJOBS", new[] { "SGJOBS" }),
        new JdeIndex("F31UI803_4", "Index on SGDOCO", new[] { "SGDOCO" }),
        new JdeIndex("F31UI803_5", "Index on SGDCT, SGEV01, SGAID, SGJOBS, SGUSER, SGPEID", new[] { "SGDCT", "SGEV01", "SGAID", "SGJOBS", "SGUSER", "SGPEID" })
    };
}
