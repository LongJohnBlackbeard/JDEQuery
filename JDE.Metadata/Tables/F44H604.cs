using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H604 - .
/// </summary>
public class F44H604 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VAHBAREA.
        /// </summary>
        public const string VAHBAREA = "VAHBAREA";

        /// <summary>
        /// VAR001.
        /// </summary>
        public const string VAR001 = "VAR001";

        /// <summary>
        /// VAHBMCUS.
        /// </summary>
        public const string VAHBMCUS = "VAHBMCUS";

        /// <summary>
        /// VACPHASE.
        /// </summary>
        public const string VACPHASE = "VACPHASE";

        /// <summary>
        /// VAHBLOT.
        /// </summary>
        public const string VAHBLOT = "VAHBLOT";

        /// <summary>
        /// VAOPTION.
        /// </summary>
        public const string VAOPTION = "VAOPTION";

        /// <summary>
        /// VAEFFF.
        /// </summary>
        public const string VAEFFF = "VAEFFF";

        /// <summary>
        /// VAAN8.
        /// </summary>
        public const string VAAN8 = "VAAN8";

        /// <summary>
        /// VAASNSTS.
        /// </summary>
        public const string VAASNSTS = "VAASNSTS";

        /// <summary>
        /// VAEXPR.
        /// </summary>
        public const string VAEXPR = "VAEXPR";

        /// <summary>
        /// VADOCO.
        /// </summary>
        public const string VADOCO = "VADOCO";

        /// <summary>
        /// VADCTO.
        /// </summary>
        public const string VADCTO = "VADCTO";

        /// <summary>
        /// VATRDJ.
        /// </summary>
        public const string VATRDJ = "VATRDJ";

        /// <summary>
        /// VAAVEL.
        /// </summary>
        public const string VAAVEL = "VAAVEL";

        /// <summary>
        /// VAHBST1.
        /// </summary>
        public const string VAHBST1 = "VAHBST1";

        /// <summary>
        /// VAHBST2.
        /// </summary>
        public const string VAHBST2 = "VAHBST2";

        /// <summary>
        /// VAHBST3.
        /// </summary>
        public const string VAHBST3 = "VAHBST3";

        /// <summary>
        /// VAHBST4.
        /// </summary>
        public const string VAHBST4 = "VAHBST4";

        /// <summary>
        /// VAHBST5.
        /// </summary>
        public const string VAHBST5 = "VAHBST5";

        /// <summary>
        /// VACRTU.
        /// </summary>
        public const string VACRTU = "VACRTU";

        /// <summary>
        /// VACRTJ.
        /// </summary>
        public const string VACRTJ = "VACRTJ";

        /// <summary>
        /// VACRTT.
        /// </summary>
        public const string VACRTT = "VACRTT";

        /// <summary>
        /// VAWRKSTNID.
        /// </summary>
        public const string VAWRKSTNID = "VAWRKSTNID";

        /// <summary>
        /// VAHBOPID.
        /// </summary>
        public const string VAHBOPID = "VAHBOPID";

        /// <summary>
        /// VAUPMB.
        /// </summary>
        public const string VAUPMB = "VAUPMB";

        /// <summary>
        /// VAUPMJ.
        /// </summary>
        public const string VAUPMJ = "VAUPMJ";

        /// <summary>
        /// VAUPMT.
        /// </summary>
        public const string VAUPMT = "VAUPMT";

        /// <summary>
        /// VAJOBN.
        /// </summary>
        public const string VAJOBN = "VAJOBN";

        /// <summary>
        /// VAPID.
        /// </summary>
        public const string VAPID = "VAPID";

        /// <summary>
        /// VAASNRPR.
        /// </summary>
        public const string VAASNRPR = "VAASNRPR";

        /// <summary>
        /// VANPAREA.
        /// </summary>
        public const string VANPAREA = "VANPAREA";

        /// <summary>
        /// VANPMCUS.
        /// </summary>
        public const string VANPMCUS = "VANPMCUS";

        /// <summary>
        /// VANPHASE.
        /// </summary>
        public const string VANPHASE = "VANPHASE";
    }

    /// <inheritdoc />
    public override string TableName => "F44H604";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VAHBAREA", "VAHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("VAR001", "VAR001", JdeDataType.String, 6, true, true),
        new JdeField("VAHBMCUS", "VAHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("VACPHASE", "VACPHASE", JdeDataType.String, 6, true, true),
        new JdeField("VAHBLOT", "VAHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("VAOPTION", "VAOPTION", JdeDataType.String, 16, true, true),
        new JdeField("VAEFFF", "VAEFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("VAAN8", "VAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("VAASNSTS", "VAASNSTS", JdeDataType.String, 2),
        new JdeField("VAEXPR", "VAEXPR", JdeDataType.Numeric),
        new JdeField("VADOCO", "VADOCO", JdeDataType.Numeric),
        new JdeField("VADCTO", "VADCTO", JdeDataType.String, 4),
        new JdeField("VATRDJ", "VATRDJ", JdeDataType.Numeric),
        new JdeField("VAAVEL", "VAAVEL", JdeDataType.String, 2),
        new JdeField("VAHBST1", "VAHBST1", JdeDataType.String, 2),
        new JdeField("VAHBST2", "VAHBST2", JdeDataType.String, 2),
        new JdeField("VAHBST3", "VAHBST3", JdeDataType.String, 2),
        new JdeField("VAHBST4", "VAHBST4", JdeDataType.String, 2),
        new JdeField("VAHBST5", "VAHBST5", JdeDataType.String, 2),
        new JdeField("VACRTU", "VACRTU", JdeDataType.String, 20),
        new JdeField("VACRTJ", "VACRTJ", JdeDataType.Numeric),
        new JdeField("VACRTT", "VACRTT", JdeDataType.Numeric),
        new JdeField("VAWRKSTNID", "VAWRKSTNID", JdeDataType.String, 20),
        new JdeField("VAHBOPID", "VAHBOPID", JdeDataType.String, 20),
        new JdeField("VAUPMB", "VAUPMB", JdeDataType.String, 20),
        new JdeField("VAUPMJ", "VAUPMJ", JdeDataType.Numeric),
        new JdeField("VAUPMT", "VAUPMT", JdeDataType.Numeric),
        new JdeField("VAJOBN", "VAJOBN", JdeDataType.String, 20),
        new JdeField("VAPID", "VAPID", JdeDataType.String, 20),
        new JdeField("VAASNRPR", "VAASNRPR", JdeDataType.String, 2),
        new JdeField("VANPAREA", "VANPAREA", JdeDataType.String, 6),
        new JdeField("VANPMCUS", "VANPMCUS", JdeDataType.String, 24),
        new JdeField("VANPHASE", "VANPHASE", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H604_0", "Primary Key on VAHBAREA, VAR001, VACPHASE, VAHBMCUS, VAHBLOT, VAOPTION, VAEFFF, VAAN8", new[] { "VAHBAREA", "VAR001", "VACPHASE", "VAHBMCUS", "VAHBLOT", "VAOPTION", "VAEFFF", "VAAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H604_2", "Index on VAHBAREA, VAR001, SYS_NC00034$, SYS_NC00035$, SYS_NC00036$, SYS_NC00037$", new[] { "VAHBAREA", "VAR001", "SYS_NC00034$", "SYS_NC00035$", "SYS_NC00036$", "SYS_NC00037$" }),
        new JdeIndex("F44H604_3", "Index on VAHBAREA, VAR001, VAHBMCUS, VACPHASE, VAHBLOT, VAOPTION, VAEFFF, VAEXPR", new[] { "VAHBAREA", "VAR001", "VAHBMCUS", "VACPHASE", "VAHBLOT", "VAOPTION", "VAEFFF", "VAEXPR" })
    };
}
