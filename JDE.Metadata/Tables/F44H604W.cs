using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H604W - .
/// </summary>
public class F44H604W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VWJOBS.
        /// </summary>
        public const string VWJOBS = "VWJOBS";

        /// <summary>
        /// VWAN8.
        /// </summary>
        public const string VWAN8 = "VWAN8";

        /// <summary>
        /// VWASNRPR.
        /// </summary>
        public const string VWASNRPR = "VWASNRPR";

        /// <summary>
        /// VWHBAREA.
        /// </summary>
        public const string VWHBAREA = "VWHBAREA";

        /// <summary>
        /// VWR001.
        /// </summary>
        public const string VWR001 = "VWR001";

        /// <summary>
        /// VWHBMCUS.
        /// </summary>
        public const string VWHBMCUS = "VWHBMCUS";

        /// <summary>
        /// VWCPHASE.
        /// </summary>
        public const string VWCPHASE = "VWCPHASE";

        /// <summary>
        /// VWHBLOT.
        /// </summary>
        public const string VWHBLOT = "VWHBLOT";

        /// <summary>
        /// VWOPTION.
        /// </summary>
        public const string VWOPTION = "VWOPTION";

        /// <summary>
        /// VWEFFF.
        /// </summary>
        public const string VWEFFF = "VWEFFF";

        /// <summary>
        /// VWASNSTS.
        /// </summary>
        public const string VWASNSTS = "VWASNSTS";

        /// <summary>
        /// VWEXPR.
        /// </summary>
        public const string VWEXPR = "VWEXPR";

        /// <summary>
        /// VWDOCO.
        /// </summary>
        public const string VWDOCO = "VWDOCO";

        /// <summary>
        /// VWDCTO.
        /// </summary>
        public const string VWDCTO = "VWDCTO";

        /// <summary>
        /// VWTRDJ.
        /// </summary>
        public const string VWTRDJ = "VWTRDJ";

        /// <summary>
        /// VWAVEL.
        /// </summary>
        public const string VWAVEL = "VWAVEL";

        /// <summary>
        /// VWHBST1.
        /// </summary>
        public const string VWHBST1 = "VWHBST1";

        /// <summary>
        /// VWHBST2.
        /// </summary>
        public const string VWHBST2 = "VWHBST2";

        /// <summary>
        /// VWHBST3.
        /// </summary>
        public const string VWHBST3 = "VWHBST3";

        /// <summary>
        /// VWHBST4.
        /// </summary>
        public const string VWHBST4 = "VWHBST4";

        /// <summary>
        /// VWHBST5.
        /// </summary>
        public const string VWHBST5 = "VWHBST5";

        /// <summary>
        /// VWCRTU.
        /// </summary>
        public const string VWCRTU = "VWCRTU";

        /// <summary>
        /// VWCRTJ.
        /// </summary>
        public const string VWCRTJ = "VWCRTJ";

        /// <summary>
        /// VWCRTT.
        /// </summary>
        public const string VWCRTT = "VWCRTT";

        /// <summary>
        /// VWWRKSTNID.
        /// </summary>
        public const string VWWRKSTNID = "VWWRKSTNID";

        /// <summary>
        /// VWHBOPID.
        /// </summary>
        public const string VWHBOPID = "VWHBOPID";

        /// <summary>
        /// VWUPMB.
        /// </summary>
        public const string VWUPMB = "VWUPMB";

        /// <summary>
        /// VWUPMJ.
        /// </summary>
        public const string VWUPMJ = "VWUPMJ";

        /// <summary>
        /// VWUPMT.
        /// </summary>
        public const string VWUPMT = "VWUPMT";

        /// <summary>
        /// VWJOBN.
        /// </summary>
        public const string VWJOBN = "VWJOBN";

        /// <summary>
        /// VWPID.
        /// </summary>
        public const string VWPID = "VWPID";

        /// <summary>
        /// VWNPAREA.
        /// </summary>
        public const string VWNPAREA = "VWNPAREA";

        /// <summary>
        /// VWNPMCUS.
        /// </summary>
        public const string VWNPMCUS = "VWNPMCUS";

        /// <summary>
        /// VWNPHASE.
        /// </summary>
        public const string VWNPHASE = "VWNPHASE";
    }

    /// <inheritdoc />
    public override string TableName => "F44H604W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VWJOBS", "VWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("VWAN8", "VWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("VWASNRPR", "VWASNRPR", JdeDataType.String, 2),
        new JdeField("VWHBAREA", "VWHBAREA", JdeDataType.String, 6),
        new JdeField("VWR001", "VWR001", JdeDataType.String, 6),
        new JdeField("VWHBMCUS", "VWHBMCUS", JdeDataType.String, 24),
        new JdeField("VWCPHASE", "VWCPHASE", JdeDataType.String, 6),
        new JdeField("VWHBLOT", "VWHBLOT", JdeDataType.String, 8),
        new JdeField("VWOPTION", "VWOPTION", JdeDataType.String, 16),
        new JdeField("VWEFFF", "VWEFFF", JdeDataType.Numeric),
        new JdeField("VWASNSTS", "VWASNSTS", JdeDataType.String, 2),
        new JdeField("VWEXPR", "VWEXPR", JdeDataType.Numeric),
        new JdeField("VWDOCO", "VWDOCO", JdeDataType.Numeric),
        new JdeField("VWDCTO", "VWDCTO", JdeDataType.String, 4),
        new JdeField("VWTRDJ", "VWTRDJ", JdeDataType.Numeric),
        new JdeField("VWAVEL", "VWAVEL", JdeDataType.String, 2),
        new JdeField("VWHBST1", "VWHBST1", JdeDataType.String, 2),
        new JdeField("VWHBST2", "VWHBST2", JdeDataType.String, 2),
        new JdeField("VWHBST3", "VWHBST3", JdeDataType.String, 2),
        new JdeField("VWHBST4", "VWHBST4", JdeDataType.String, 2),
        new JdeField("VWHBST5", "VWHBST5", JdeDataType.String, 2),
        new JdeField("VWCRTU", "VWCRTU", JdeDataType.String, 20),
        new JdeField("VWCRTJ", "VWCRTJ", JdeDataType.Numeric),
        new JdeField("VWCRTT", "VWCRTT", JdeDataType.Numeric),
        new JdeField("VWWRKSTNID", "VWWRKSTNID", JdeDataType.String, 20),
        new JdeField("VWHBOPID", "VWHBOPID", JdeDataType.String, 20),
        new JdeField("VWUPMB", "VWUPMB", JdeDataType.String, 20),
        new JdeField("VWUPMJ", "VWUPMJ", JdeDataType.Numeric),
        new JdeField("VWUPMT", "VWUPMT", JdeDataType.Numeric),
        new JdeField("VWJOBN", "VWJOBN", JdeDataType.String, 20),
        new JdeField("VWPID", "VWPID", JdeDataType.String, 20),
        new JdeField("VWNPAREA", "VWNPAREA", JdeDataType.String, 6),
        new JdeField("VWNPMCUS", "VWNPMCUS", JdeDataType.String, 24),
        new JdeField("VWNPHASE", "VWNPHASE", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H604W_0", "Primary Key on VWJOBS, VWAN8", new[] { "VWJOBS", "VWAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H604W_2", "Index on VWJOBS, VWAN8, VWR001, VWOPTION, VWASNSTS", new[] { "VWJOBS", "VWAN8", "VWR001", "VWOPTION", "VWASNSTS" })
    };
}
