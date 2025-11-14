using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0201 - .
/// </summary>
public class F74U0201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P1CO.
        /// </summary>
        public const string P1CO = "P1CO";

        /// <summary>
        /// P174ULYR.
        /// </summary>
        public const string P174ULYR = "P174ULYR";

        /// <summary>
        /// P174UNYC.
        /// </summary>
        public const string P174UNYC = "P174UNYC";

        /// <summary>
        /// P174UFMOD.
        /// </summary>
        public const string P174UFMOD = "P174UFMOD";

        /// <summary>
        /// P174UFMID.
        /// </summary>
        public const string P174UFMID = "P174UFMID";

        /// <summary>
        /// P174UCCM.
        /// </summary>
        public const string P174UCCM = "P174UCCM";

        /// <summary>
        /// P174UPNF.
        /// </summary>
        public const string P174UPNF = "P174UPNF";

        /// <summary>
        /// P174UVATOE.
        /// </summary>
        public const string P174UVATOE = "P174UVATOE";

        /// <summary>
        /// P174UVOO.
        /// </summary>
        public const string P174UVOO = "P174UVOO";

        /// <summary>
        /// P174UMTC.
        /// </summary>
        public const string P174UMTC = "P174UMTC";

        /// <summary>
        /// P174UTCOO.
        /// </summary>
        public const string P174UTCOO = "P174UTCOO";

        /// <summary>
        /// P174UTAOO.
        /// </summary>
        public const string P174UTAOO = "P174UTAOO";

        /// <summary>
        /// P174URBC.
        /// </summary>
        public const string P174URBC = "P174URBC";

        /// <summary>
        /// P174UCBC.
        /// </summary>
        public const string P174UCBC = "P174UCBC";

        /// <summary>
        /// P174UUA.
        /// </summary>
        public const string P174UUA = "P174UUA";

        /// <summary>
        /// P174UAIDC.
        /// </summary>
        public const string P174UAIDC = "P174UAIDC";

        /// <summary>
        /// P174UAJM.
        /// </summary>
        public const string P174UAJM = "P174UAJM";

        /// <summary>
        /// P174UWA.
        /// </summary>
        public const string P174UWA = "P174UWA";

        /// <summary>
        /// P174USSBU.
        /// </summary>
        public const string P174USSBU = "P174USSBU";

        /// <summary>
        /// P174UPBD.
        /// </summary>
        public const string P174UPBD = "P174UPBD";

        /// <summary>
        /// P174UPW1.
        /// </summary>
        public const string P174UPW1 = "P174UPW1";

        /// <summary>
        /// P174UPW2.
        /// </summary>
        public const string P174UPW2 = "P174UPW2";

        /// <summary>
        /// P174UPW3.
        /// </summary>
        public const string P174UPW3 = "P174UPW3";

        /// <summary>
        /// P174UPW4.
        /// </summary>
        public const string P174UPW4 = "P174UPW4";

        /// <summary>
        /// P174UPW5.
        /// </summary>
        public const string P174UPW5 = "P174UPW5";

        /// <summary>
        /// P174UPW6.
        /// </summary>
        public const string P174UPW6 = "P174UPW6";

        /// <summary>
        /// P174UPW7.
        /// </summary>
        public const string P174UPW7 = "P174UPW7";

        /// <summary>
        /// P174UPW8.
        /// </summary>
        public const string P174UPW8 = "P174UPW8";

        /// <summary>
        /// P174UPW9.
        /// </summary>
        public const string P174UPW9 = "P174UPW9";

        /// <summary>
        /// P174UPW10.
        /// </summary>
        public const string P174UPW10 = "P174UPW10";

        /// <summary>
        /// P174UPW11.
        /// </summary>
        public const string P174UPW11 = "P174UPW11";

        /// <summary>
        /// P174UPW12.
        /// </summary>
        public const string P174UPW12 = "P174UPW12";

        /// <summary>
        /// P174UNNP.
        /// </summary>
        public const string P174UNNP = "P174UNNP";

        /// <summary>
        /// P1URCD.
        /// </summary>
        public const string P1URCD = "P1URCD";

        /// <summary>
        /// P1URDT.
        /// </summary>
        public const string P1URDT = "P1URDT";

        /// <summary>
        /// P1URAB.
        /// </summary>
        public const string P1URAB = "P1URAB";

        /// <summary>
        /// P1URRF.
        /// </summary>
        public const string P1URRF = "P1URRF";

        /// <summary>
        /// P1USER.
        /// </summary>
        public const string P1USER = "P1USER";

        /// <summary>
        /// P1PID.
        /// </summary>
        public const string P1PID = "P1PID";

        /// <summary>
        /// P1UPMJ.
        /// </summary>
        public const string P1UPMJ = "P1UPMJ";

        /// <summary>
        /// P1UPMT.
        /// </summary>
        public const string P1UPMT = "P1UPMT";

        /// <summary>
        /// P1JOBN.
        /// </summary>
        public const string P1JOBN = "P1JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P1CO", "P1CO", JdeDataType.String, 10, true, true),
        new JdeField("P174ULYR", "P174ULYR", JdeDataType.String, 2),
        new JdeField("P174UNYC", "P174UNYC", JdeDataType.Numeric),
        new JdeField("P174UFMOD", "P174UFMOD", JdeDataType.String, 2),
        new JdeField("P174UFMID", "P174UFMID", JdeDataType.String, 2),
        new JdeField("P174UCCM", "P174UCCM", JdeDataType.String, 6),
        new JdeField("P174UPNF", "P174UPNF", JdeDataType.String, 6),
        new JdeField("P174UVATOE", "P174UVATOE", JdeDataType.String, 2),
        new JdeField("P174UVOO", "P174UVOO", JdeDataType.String, 6),
        new JdeField("P174UMTC", "P174UMTC", JdeDataType.String, 2),
        new JdeField("P174UTCOO", "P174UTCOO", JdeDataType.String, 4),
        new JdeField("P174UTAOO", "P174UTAOO", JdeDataType.String, 20),
        new JdeField("P174URBC", "P174URBC", JdeDataType.String, 20),
        new JdeField("P174UCBC", "P174UCBC", JdeDataType.String, 20),
        new JdeField("P174UUA", "P174UUA", JdeDataType.String, 6),
        new JdeField("P174UAIDC", "P174UAIDC", JdeDataType.String, 2),
        new JdeField("P174UAJM", "P174UAJM", JdeDataType.String, 4),
        new JdeField("P174UWA", "P174UWA", JdeDataType.String, 2),
        new JdeField("P174USSBU", "P174USSBU", JdeDataType.String, 2),
        new JdeField("P174UPBD", "P174UPBD", JdeDataType.String, 2),
        new JdeField("P174UPW1", "P174UPW1", JdeDataType.String, 2),
        new JdeField("P174UPW2", "P174UPW2", JdeDataType.String, 2),
        new JdeField("P174UPW3", "P174UPW3", JdeDataType.String, 2),
        new JdeField("P174UPW4", "P174UPW4", JdeDataType.String, 2),
        new JdeField("P174UPW5", "P174UPW5", JdeDataType.String, 2),
        new JdeField("P174UPW6", "P174UPW6", JdeDataType.String, 2),
        new JdeField("P174UPW7", "P174UPW7", JdeDataType.String, 2),
        new JdeField("P174UPW8", "P174UPW8", JdeDataType.String, 2),
        new JdeField("P174UPW9", "P174UPW9", JdeDataType.String, 2),
        new JdeField("P174UPW10", "P174UPW10", JdeDataType.String, 2),
        new JdeField("P174UPW11", "P174UPW11", JdeDataType.String, 2),
        new JdeField("P174UPW12", "P174UPW12", JdeDataType.String, 2),
        new JdeField("P174UNNP", "P174UNNP", JdeDataType.Numeric),
        new JdeField("P1URCD", "P1URCD", JdeDataType.String, 4),
        new JdeField("P1URDT", "P1URDT", JdeDataType.Numeric),
        new JdeField("P1URAB", "P1URAB", JdeDataType.Numeric),
        new JdeField("P1URRF", "P1URRF", JdeDataType.String, 30),
        new JdeField("P1USER", "P1USER", JdeDataType.String, 20),
        new JdeField("P1PID", "P1PID", JdeDataType.String, 20),
        new JdeField("P1UPMJ", "P1UPMJ", JdeDataType.Numeric),
        new JdeField("P1UPMT", "P1UPMT", JdeDataType.Numeric),
        new JdeField("P1JOBN", "P1JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0201_0", "Primary Key on P1CO", new[] { "P1CO" }, isUnique: true, isPrimaryKey: true)
    };
}
