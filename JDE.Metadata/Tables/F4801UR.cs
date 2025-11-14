using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4801UR - .
/// </summary>
public class F4801UR : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// URDOCO.
        /// </summary>
        public const string URDOCO = "URDOCO";

        /// <summary>
        /// UREXVAR0.
        /// </summary>
        public const string UREXVAR0 = "UREXVAR0";

        /// <summary>
        /// UREXVAR1.
        /// </summary>
        public const string UREXVAR1 = "UREXVAR1";

        /// <summary>
        /// UREXVAR4.
        /// </summary>
        public const string UREXVAR4 = "UREXVAR4";

        /// <summary>
        /// UREXVAR5.
        /// </summary>
        public const string UREXVAR5 = "UREXVAR5";

        /// <summary>
        /// UREXVAR6.
        /// </summary>
        public const string UREXVAR6 = "UREXVAR6";

        /// <summary>
        /// UREXVAR7.
        /// </summary>
        public const string UREXVAR7 = "UREXVAR7";

        /// <summary>
        /// UREXVAR12.
        /// </summary>
        public const string UREXVAR12 = "UREXVAR12";

        /// <summary>
        /// UREXVAR13.
        /// </summary>
        public const string UREXVAR13 = "UREXVAR13";

        /// <summary>
        /// UREXNM0.
        /// </summary>
        public const string UREXNM0 = "UREXNM0";

        /// <summary>
        /// UREXNM1.
        /// </summary>
        public const string UREXNM1 = "UREXNM1";

        /// <summary>
        /// UREXNM2.
        /// </summary>
        public const string UREXNM2 = "UREXNM2";

        /// <summary>
        /// UREXNMP0.
        /// </summary>
        public const string UREXNMP0 = "UREXNMP0";

        /// <summary>
        /// UREXNMP1.
        /// </summary>
        public const string UREXNMP1 = "UREXNMP1";

        /// <summary>
        /// UREXNMP2.
        /// </summary>
        public const string UREXNMP2 = "UREXNMP2";

        /// <summary>
        /// UREXDT0.
        /// </summary>
        public const string UREXDT0 = "UREXDT0";

        /// <summary>
        /// UREXDT1.
        /// </summary>
        public const string UREXDT1 = "UREXDT1";

        /// <summary>
        /// UREXDT2.
        /// </summary>
        public const string UREXDT2 = "UREXDT2";

        /// <summary>
        /// URUSER.
        /// </summary>
        public const string URUSER = "URUSER";

        /// <summary>
        /// URPID.
        /// </summary>
        public const string URPID = "URPID";

        /// <summary>
        /// URVID.
        /// </summary>
        public const string URVID = "URVID";

        /// <summary>
        /// URMKEY.
        /// </summary>
        public const string URMKEY = "URMKEY";

        /// <summary>
        /// URUDTTM.
        /// </summary>
        public const string URUDTTM = "URUDTTM";

        /// <summary>
        /// UREXVAR2.
        /// </summary>
        public const string UREXVAR2 = "UREXVAR2";

        /// <summary>
        /// UREXVAR3.
        /// </summary>
        public const string UREXVAR3 = "UREXVAR3";

        /// <summary>
        /// UREXVAR8.
        /// </summary>
        public const string UREXVAR8 = "UREXVAR8";

        /// <summary>
        /// UREXVAR9.
        /// </summary>
        public const string UREXVAR9 = "UREXVAR9";

        /// <summary>
        /// UREXVAR10.
        /// </summary>
        public const string UREXVAR10 = "UREXVAR10";

        /// <summary>
        /// UREXVAR11.
        /// </summary>
        public const string UREXVAR11 = "UREXVAR11";

        /// <summary>
        /// UREXVAR14.
        /// </summary>
        public const string UREXVAR14 = "UREXVAR14";

        /// <summary>
        /// UREXNM3.
        /// </summary>
        public const string UREXNM3 = "UREXNM3";

        /// <summary>
        /// UREXNM4.
        /// </summary>
        public const string UREXNM4 = "UREXNM4";

        /// <summary>
        /// UREXNMP3.
        /// </summary>
        public const string UREXNMP3 = "UREXNMP3";

        /// <summary>
        /// UREXNMP4.
        /// </summary>
        public const string UREXNMP4 = "UREXNMP4";

        /// <summary>
        /// UREXDT3.
        /// </summary>
        public const string UREXDT3 = "UREXDT3";

        /// <summary>
        /// UREXDT4.
        /// </summary>
        public const string UREXDT4 = "UREXDT4";
    }

    /// <inheritdoc />
    public override string TableName => "F4801UR";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("URDOCO", "URDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("UREXVAR0", "UREXVAR0", JdeDataType.String, 510),
        new JdeField("UREXVAR1", "UREXVAR1", JdeDataType.String, 510),
        new JdeField("UREXVAR4", "UREXVAR4", JdeDataType.String, 100),
        new JdeField("UREXVAR5", "UREXVAR5", JdeDataType.String, 100),
        new JdeField("UREXVAR6", "UREXVAR6", JdeDataType.String, 100),
        new JdeField("UREXVAR7", "UREXVAR7", JdeDataType.String, 100),
        new JdeField("UREXVAR12", "UREXVAR12", JdeDataType.String, 50),
        new JdeField("UREXVAR13", "UREXVAR13", JdeDataType.String, 50),
        new JdeField("UREXNM0", "UREXNM0", JdeDataType.Numeric),
        new JdeField("UREXNM1", "UREXNM1", JdeDataType.Numeric),
        new JdeField("UREXNM2", "UREXNM2", JdeDataType.Numeric),
        new JdeField("UREXNMP0", "UREXNMP0", JdeDataType.Numeric),
        new JdeField("UREXNMP1", "UREXNMP1", JdeDataType.Numeric),
        new JdeField("UREXNMP2", "UREXNMP2", JdeDataType.Numeric),
        new JdeField("UREXDT0", "UREXDT0", JdeDataType.Date),
        new JdeField("UREXDT1", "UREXDT1", JdeDataType.Date),
        new JdeField("UREXDT2", "UREXDT2", JdeDataType.Date),
        new JdeField("URUSER", "URUSER", JdeDataType.String, 20),
        new JdeField("URPID", "URPID", JdeDataType.String, 20),
        new JdeField("URVID", "URVID", JdeDataType.String, 20),
        new JdeField("URMKEY", "URMKEY", JdeDataType.String, 30),
        new JdeField("URUDTTM", "URUDTTM", JdeDataType.Date),
        new JdeField("UREXVAR2", "UREXVAR2", JdeDataType.String, 510),
        new JdeField("UREXVAR3", "UREXVAR3", JdeDataType.String, 510),
        new JdeField("UREXVAR8", "UREXVAR8", JdeDataType.String, 100),
        new JdeField("UREXVAR9", "UREXVAR9", JdeDataType.String, 100),
        new JdeField("UREXVAR10", "UREXVAR10", JdeDataType.String, 100),
        new JdeField("UREXVAR11", "UREXVAR11", JdeDataType.String, 100),
        new JdeField("UREXVAR14", "UREXVAR14", JdeDataType.String, 50),
        new JdeField("UREXNM3", "UREXNM3", JdeDataType.Numeric),
        new JdeField("UREXNM4", "UREXNM4", JdeDataType.Numeric),
        new JdeField("UREXNMP3", "UREXNMP3", JdeDataType.Numeric),
        new JdeField("UREXNMP4", "UREXNMP4", JdeDataType.Numeric),
        new JdeField("UREXDT3", "UREXDT3", JdeDataType.Date),
        new JdeField("UREXDT4", "UREXDT4", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4801UR_0", "Primary Key on URDOCO", new[] { "URDOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
