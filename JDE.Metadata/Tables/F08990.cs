using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08990 - .
/// </summary>
public class F08990 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HWCO.
        /// </summary>
        public const string HWCO = "HWCO";

        /// <summary>
        /// HWHMCU.
        /// </summary>
        public const string HWHMCU = "HWHMCU";

        /// <summary>
        /// HWEFTB.
        /// </summary>
        public const string HWEFTB = "HWEFTB";

        /// <summary>
        /// HWEFTE.
        /// </summary>
        public const string HWEFTE = "HWEFTE";

        /// <summary>
        /// HWTARR.
        /// </summary>
        public const string HWTARR = "HWTARR";

        /// <summary>
        /// HWCOVF.
        /// </summary>
        public const string HWCOVF = "HWCOVF";

        /// <summary>
        /// HWFLDR.
        /// </summary>
        public const string HWFLDR = "HWFLDR";

        /// <summary>
        /// HWCBRN.
        /// </summary>
        public const string HWCBRN = "HWCBRN";

        /// <summary>
        /// HWPLND.
        /// </summary>
        public const string HWPLND = "HWPLND";

        /// <summary>
        /// HWCTND.
        /// </summary>
        public const string HWCTND = "HWCTND";

        /// <summary>
        /// HWAFRA.
        /// </summary>
        public const string HWAFRA = "HWAFRA";

        /// <summary>
        /// HWAFDA.
        /// </summary>
        public const string HWAFDA = "HWAFDA";

        /// <summary>
        /// HWAFR.
        /// </summary>
        public const string HWAFR = "HWAFR";

        /// <summary>
        /// HWAFD.
        /// </summary>
        public const string HWAFD = "HWAFD";

        /// <summary>
        /// HWELCP.
        /// </summary>
        public const string HWELCP = "HWELCP";

        /// <summary>
        /// HWELPF.
        /// </summary>
        public const string HWELPF = "HWELPF";

        /// <summary>
        /// HWGRCI.
        /// </summary>
        public const string HWGRCI = "HWGRCI";

        /// <summary>
        /// HWINPF.
        /// </summary>
        public const string HWINPF = "HWINPF";

        /// <summary>
        /// HWGRCP.
        /// </summary>
        public const string HWGRCP = "HWGRCP";

        /// <summary>
        /// HWAPPF.
        /// </summary>
        public const string HWAPPF = "HWAPPF";

        /// <summary>
        /// HWRCCN.
        /// </summary>
        public const string HWRCCN = "HWRCCN";

        /// <summary>
        /// HWPBCN.
        /// </summary>
        public const string HWPBCN = "HWPBCN";

        /// <summary>
        /// HWDSCN.
        /// </summary>
        public const string HWDSCN = "HWDSCN";

        /// <summary>
        /// HWSTFL.
        /// </summary>
        public const string HWSTFL = "HWSTFL";

        /// <summary>
        /// HWSMFQ.
        /// </summary>
        public const string HWSMFQ = "HWSMFQ";

        /// <summary>
        /// HWCRHP.
        /// </summary>
        public const string HWCRHP = "HWCRHP";

        /// <summary>
        /// HWPTAB.
        /// </summary>
        public const string HWPTAB = "HWPTAB";

        /// <summary>
        /// HWCPA8.
        /// </summary>
        public const string HWCPA8 = "HWCPA8";

        /// <summary>
        /// HWAFRP.
        /// </summary>
        public const string HWAFRP = "HWAFRP";

        /// <summary>
        /// HWRAFF.
        /// </summary>
        public const string HWRAFF = "HWRAFF";

        /// <summary>
        /// HWAFDP.
        /// </summary>
        public const string HWAFDP = "HWAFDP";

        /// <summary>
        /// HWDAFF.
        /// </summary>
        public const string HWDAFF = "HWDAFF";

        /// <summary>
        /// HWMRS.
        /// </summary>
        public const string HWMRS = "HWMRS";

        /// <summary>
        /// HWCFC.
        /// </summary>
        public const string HWCFC = "HWCFC";

        /// <summary>
        /// HWCFCM.
        /// </summary>
        public const string HWCFCM = "HWCFCM";

        /// <summary>
        /// HWCRPF.
        /// </summary>
        public const string HWCRPF = "HWCRPF";

        /// <summary>
        /// HWCPPD.
        /// </summary>
        public const string HWCPPD = "HWCPPD";

        /// <summary>
        /// HWCCBF.
        /// </summary>
        public const string HWCCBF = "HWCCBF";

        /// <summary>
        /// HWUSER.
        /// </summary>
        public const string HWUSER = "HWUSER";

        /// <summary>
        /// HWEAP.
        /// </summary>
        public const string HWEAP = "HWEAP";

        /// <summary>
        /// HWMACH.
        /// </summary>
        public const string HWMACH = "HWMACH";

        /// <summary>
        /// HWUPMJ.
        /// </summary>
        public const string HWUPMJ = "HWUPMJ";

        /// <summary>
        /// HWUPMT.
        /// </summary>
        public const string HWUPMT = "HWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08990";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HWCO", "HWCO", JdeDataType.String, 10, true, true),
        new JdeField("HWHMCU", "HWHMCU", JdeDataType.String, 24, true, true),
        new JdeField("HWEFTB", "HWEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("HWEFTE", "HWEFTE", JdeDataType.Numeric),
        new JdeField("HWTARR", "HWTARR", JdeDataType.String, 20, true, true),
        new JdeField("HWCOVF", "HWCOVF", JdeDataType.String, 2),
        new JdeField("HWFLDR", "HWFLDR", JdeDataType.String, 60),
        new JdeField("HWCBRN", "HWCBRN", JdeDataType.String, 24),
        new JdeField("HWPLND", "HWPLND", JdeDataType.Numeric),
        new JdeField("HWCTND", "HWCTND", JdeDataType.String, 24),
        new JdeField("HWAFRA", "HWAFRA", JdeDataType.Numeric),
        new JdeField("HWAFDA", "HWAFDA", JdeDataType.Numeric),
        new JdeField("HWAFR", "HWAFR", JdeDataType.String, 2),
        new JdeField("HWAFD", "HWAFD", JdeDataType.String, 2),
        new JdeField("HWELCP", "HWELCP", JdeDataType.Numeric),
        new JdeField("HWELPF", "HWELPF", JdeDataType.String, 2),
        new JdeField("HWGRCI", "HWGRCI", JdeDataType.Numeric),
        new JdeField("HWINPF", "HWINPF", JdeDataType.String, 2),
        new JdeField("HWGRCP", "HWGRCP", JdeDataType.Numeric),
        new JdeField("HWAPPF", "HWAPPF", JdeDataType.String, 2),
        new JdeField("HWRCCN", "HWRCCN", JdeDataType.String, 24),
        new JdeField("HWPBCN", "HWPBCN", JdeDataType.String, 24),
        new JdeField("HWDSCN", "HWDSCN", JdeDataType.String, 24),
        new JdeField("HWSTFL", "HWSTFL", JdeDataType.String, 2),
        new JdeField("HWSMFQ", "HWSMFQ", JdeDataType.String, 2),
        new JdeField("HWCRHP", "HWCRHP", JdeDataType.Numeric),
        new JdeField("HWPTAB", "HWPTAB", JdeDataType.String, 8),
        new JdeField("HWCPA8", "HWCPA8", JdeDataType.Numeric),
        new JdeField("HWAFRP", "HWAFRP", JdeDataType.Numeric),
        new JdeField("HWRAFF", "HWRAFF", JdeDataType.String, 2),
        new JdeField("HWAFDP", "HWAFDP", JdeDataType.Numeric),
        new JdeField("HWDAFF", "HWDAFF", JdeDataType.String, 2),
        new JdeField("HWMRS", "HWMRS", JdeDataType.String, 2),
        new JdeField("HWCFC", "HWCFC", JdeDataType.Numeric),
        new JdeField("HWCFCM", "HWCFCM", JdeDataType.String, 2),
        new JdeField("HWCRPF", "HWCRPF", JdeDataType.String, 2),
        new JdeField("HWCPPD", "HWCPPD", JdeDataType.Numeric),
        new JdeField("HWCCBF", "HWCCBF", JdeDataType.String, 2),
        new JdeField("HWUSER", "HWUSER", JdeDataType.String, 20),
        new JdeField("HWEAP", "HWEAP", JdeDataType.String, 20),
        new JdeField("HWMACH", "HWMACH", JdeDataType.String, 24),
        new JdeField("HWUPMJ", "HWUPMJ", JdeDataType.Numeric),
        new JdeField("HWUPMT", "HWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08990_0", "Primary Key on HWCO, HWHMCU, HWTARR, HWEFTB", new[] { "HWCO", "HWHMCU", "HWTARR", "HWEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08990_2", "Index on HWCO, HWHMCU, HWEFTB, HWEFTE", new[] { "HWCO", "HWHMCU", "HWEFTB", "HWEFTE" }),
        new JdeIndex("F08990_5", "Index on HWCO, HWEFTB, HWEFTE", new[] { "HWCO", "HWEFTB", "HWEFTE" }),
        new JdeIndex("F08990_6", "Index on HWCO, HWTARR, HWEFTB, HWEFTE", new[] { "HWCO", "HWTARR", "HWEFTB", "HWEFTE" }),
        new JdeIndex("F08990_7", "Index on HWCO, SYS_NC00044$, SYS_NC00045$, HWTARR, HWHMCU", new[] { "HWCO", "SYS_NC00044$", "SYS_NC00045$", "HWTARR", "HWHMCU" })
    };
}
